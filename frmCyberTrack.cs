using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSBComponents.Component;
using CSBComponents.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using CYBERTRACK_DESKTOP.Models;
using System.IO;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace CYBERTRACK_DESKTOP
{
    public partial class FrmCyberTrack : Form
    {
        public FrmCyberTrack()
        {
            InitializeComponent();
            uiButton1.Focus();
            RoundedForm roundedForm = new RoundedForm(this);
        }

        private void frmCyberTrack_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.GetTempPath() + @"\CyberApp\CyberTrack"))
            {
                string[] files = Directory.GetFiles(Path.GetTempPath() + @"\CyberApp\CyberTrack");

                foreach (var file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if (fileInfo.Extension.Equals(".json"))
                    {
                        var item = Objeto.FromJson(File.ReadAllText(file));
                        if (Regex.Match(item.Codigo, @"^[A-Z]{2}[\d]{9}[A-Z]{2}$").Success)
                        {
                            uiItem uiItem = new uiItem();
                            uiItem.ItemTitle = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                            uiItem.ItemCodigoRastreio = item.Codigo;
                            uiItem.ItemImage = Properties.Resources.correios;
                            uiItem.Click += UiItem_Click;
                            uiItem.Tag = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                            uiItem.LabelTitle.Click += UiItem_Click;
                            uiItem.LabelTitle.Tag = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                            uiItem.LabelCompany.Click += UiItem_Click;
                            uiItem.LabelCompany.Tag = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                            uiItem.PictureCompany.Click += UiItem_Click;
                            uiItem.PictureCompany.Tag = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                            uiFlowEncomendas.Controls.Add(uiItem);
                        }
                    }
                }
            }
        }

        private void UiItem_Click(object sender, EventArgs e)
        {
            var eventJson = string.Empty;

            if (sender is Panel)
            {
                Panel panel = sender as Panel;
                eventJson = File.ReadAllText(Path.GetTempPath() + String.Format(@"\CyberApp\CyberTrack\{0}.json", panel.Tag));

            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                eventJson = File.ReadAllText(Path.GetTempPath() + String.Format(@"\CyberApp\CyberTrack\{0}.json", label.Tag));
            }
            else if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                eventJson = File.ReadAllText(Path.GetTempPath() + String.Format(@"\CyberApp\CyberTrack\{0}.json", pictureBox.Tag));
            }
            else if (sender is uiItem)
            {
                uiItem item = sender as uiItem;
                eventJson = File.ReadAllText(Path.GetTempPath() + String.Format(@"\CyberApp\CyberTrack\{0}.json", item.Tag));
            }

            CreateBoxEvent(Objeto.FromJson(eventJson));
        }

        public void CreateBoxEvent(Objeto objeto)
        {
            flowEventos.Controls.Clear();

            foreach (var evento in objeto.Eventos)
            {
                BoxEvento boxEvento = new BoxEvento()
                {
                    LabelStatus = evento.Status,
                    LabelData = evento.Data,
                    LabelOrigem = evento.Local,
                    LabelDestino = evento.SubStatus[0]
                };

                //var destinos = "";

                //foreach (var destino in evento.SubStatus)
                //{
                //    destinos += destino + Environment.NewLine;
                //    //boxEvento.LabelDestino += destino + Environment.NewLine;
                //}

                flowEventos.Controls.Add(boxEvento);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.linketrack.com/track/json?user=teste&token=1abcd00b2731640e886fb41a8a9671ad1434c599dbaa0a0de9a5aa619f29a83f&codigo=" + txtCodigoRastreio.Text);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (IsValidateJSON(response.Content))
            {
                switch (response.StatusCode)
                {
                    case HttpStatusCode.OK:
                        // Se o directório "Temp\CyberApp\CyberTrack não existe crie.
                        if (!Directory.Exists(Path.GetTempPath() + String.Format(@"\CyberApp\CyberTrack")))
                        {
                            Directory.CreateDirectory(Path.GetTempPath() + @"\CyberApp\CyberTrack");
                        }

                        // Cria um arquivo .JSON para o objeto no directório "Temp /CyberApp/CyberTrack"
                        File.WriteAllText(Path.GetTempPath() + String.Format(@"\CyberApp\CyberTrack\{0}.json", txtTitulo.Text), response.Content);
                        break;
                    case HttpStatusCode.NotFound:
                        break;
                    case HttpStatusCode.InternalServerError:
                        MessageBox.Show("arruma isso ae camarada");
                        break;
                }
            }
            else
            {

            }

            uiItem uiItem = new uiItem()
            {
                ItemTitle = txtTitulo.Text,
                ItemCodigoRastreio = txtCodigoRastreio.Text,
                ItemImage = Properties.Resources.correios,
            };

            uiFlowEncomendas.Controls.Add(uiItem);
        }

        // From: https://stackoverflow.com/a/31404282 by: Tom Beech; Thank You!
        public bool IsValidateJSON(string s)
        {
            try
            {
                JToken.Parse(s);
                return true;
            }
            catch (JsonReaderException ex)
            {
                Trace.WriteLine(ex);
                return false;
            }
        }
    }
}
