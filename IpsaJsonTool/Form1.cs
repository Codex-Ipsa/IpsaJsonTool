using IpsaJsonTool.ipsajson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpsaJsonTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "IpsaJsonTool v0.0.1 | (c) DEJVOSS Productions";
        }

        public void ImportIpsa(string path)
        {
            Debug.WriteLine(path);
            string jsonText = File.ReadAllText(path);

            IpsaJson ij = JsonConvert.DeserializeObject<IpsaJson>(jsonText);

            DataTable libs = new DataTable();
            libs.Columns.Add("Name");
            libs.Columns.Add("URL");
            libs.Columns.Add("Size");
            libs.Columns.Add("Extract");
            libsDataGridView.DataSource = libs;

            DataTable supplement = new DataTable();
            supplement.Columns.Add("URL");
            supplement.Columns.Add("Path");
            supplement.Columns.Add("Name");
            supplement.Columns.Add("Renew");
            supplementDataGridView.DataSource = supplement;

            sizeBox.Maximum = decimal.MaxValue;
            javaBox.Maximum = 20;
            string[] defRes = ij.defRes.Split(' ');
            defResXBox.Maximum = 1920;
            defResYBox.Maximum = 1080;
            assetsSizeBox.Maximum = decimal.MaxValue;
            assetsFileSizeBox.Maximum = decimal.MaxValue;

            gameBox.Text = ij.game;
            versionBox.Text = ij.version;
            urlBox.Text = ij.url;
            sizeBox.Value = ij.size;
            javaBox.Value = ij.java;
            cmdAftBox.Text = ij.cmdAft;
            cmdBefBox.Text = ij.cmdBef;
            defResXBox.Value = decimal.Parse(defRes[0]);
            defResYBox.Value = decimal.Parse(defRes[1]);
            joinServerCheck.Checked = ij.srvJoin;
            assetsVirtCheck.Checked = ij.assetsVirt;
            loggingBox.Text = ij.logging;
            classpathBox.Text = ij.classpath;

            assetsNameBox.Text = ij.assets.name;
            assetsUrlBox.Text = ij.assets.url;
            assetsSizeBox.Value = ij.assets.size;
            assetsFileSizeBox.Value = ij.assets.fileSize;

            if (ij.libraries != null)
            {
                int libCol = 0;
                foreach (IpsaJsonLibraries lib in ij.libraries)
                {
                    libs.Rows.Add();
                    libs.Rows[libCol][0] = $"{lib.name}";
                    libs.Rows[libCol][1] = $"{lib.url}";
                    libs.Rows[libCol][2] = $"{lib.size}";
                    libs.Rows[libCol][3] = $"{lib.extract}";

                    libCol++;
                }
                libsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                libsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                libsDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                libsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (ij.supplement != null)
            {
                int supCol = 0;
                foreach (IpsaJsonSupplement sup in ij.supplement)
                {
                    supplement.Rows.Add();
                    supplement.Rows[supCol][0] = $"{sup.name}"; //2 (orig pos in json, shouldn't really matter anyways)
                    supplement.Rows[supCol][1] = $"{sup.path}"; //1
                    supplement.Rows[supCol][2] = $"{sup.url}"; //0
                    supplement.Rows[supCol][3] = $"{sup.renew}"; //3

                    supCol++;
                }

                supplementDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                supplementDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                supplementDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                supplementDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void ExportIpsa(string path)
        {
            //Debug.WriteLine(path);
            //string jsonText = File.ReadAllText(path);

            IpsaJson ij = new IpsaJson();

            //DataTable supplement = ((DataRowView)supplementDataGridView.Rows[0].DataBoundItem).DataView.Table;

            ij.game = gameBox.Text;
            ij.version = versionBox.Text;
            ij.url = urlBox.Text;
            ij.size = (int)sizeBox.Value;
            ij.java = (int)javaBox.Value;
            ij.cmdAft = cmdAftBox.Text;
            ij.cmdBef = cmdBefBox.Text;
            ij.defRes = $"{defResXBox.Value} {defResYBox.Value}";
            ij.srvJoin = joinServerCheck.Checked;
            //ij.assetsVirt = assetsVirtCheck.Checked; //todo some shit with this because deprecated
            ij.logging = loggingBox.Text;
            ij.classpath = classpathBox.Text;

            IpsaJsonAssets ija = new IpsaJsonAssets();
            ija.name = assetsNameBox.Text;
            ija.url = assetsUrlBox.Text;
            ija.size = (int)assetsSizeBox.Value;
            ija.fileSize = (int)assetsFileSizeBox.Value;
            ij.assets = ija;

            if (libsDataGridView.Rows.Count > 1)
            {
                List<IpsaJsonLibraries> ijl = new List<IpsaJsonLibraries>();

                DataTable libs = ((DataRowView)libsDataGridView.Rows[0].DataBoundItem).DataView.Table;

                for (int row = 0; row < libs.Rows.Count; row++)
                {
                    IpsaJsonLibraries newOne = new IpsaJsonLibraries();
                    for (int col = 0; col < libs.Columns.Count; col++)
                    {
                        if (col == 0)
                            newOne.name = libs.Rows[row][col].ToString();
                        else if (col == 1)
                            newOne.url = libs.Rows[row][col].ToString();
                        else if (col == 2)
                            newOne.size = (int.Parse(libs.Rows[row][col].ToString()));
                        else if (col == 3)
                            newOne.extract = (bool.Parse(libs.Rows[row][col].ToString()));

                        Debug.WriteLine($"{col} {row}:  {libs.Rows[row][col]}");
                    }
                    ijl.Add(newOne);
                }
                ij.libraries = ijl.ToArray();

                if (supplementDataGridView.Rows.Count > 1)
                {
                    List<IpsaJsonSupplement> ijs = new List<IpsaJsonSupplement>();

                    DataTable supplement = ((DataRowView)supplementDataGridView.Rows[0].DataBoundItem).DataView.Table;

                    for (int row = 0; row < supplement.Rows.Count; row++)
                    {
                        IpsaJsonSupplement newOne = new IpsaJsonSupplement();
                        for (int col = 0; col < supplement.Columns.Count; col++)
                        {
                            if (col == 0)
                                newOne.name = supplement.Rows[row][col].ToString();
                            else if (col == 1)
                                newOne.path = supplement.Rows[row][col].ToString();
                            else if (col == 2)
                                newOne.url = supplement.Rows[row][col].ToString();
                            else if (col == 3)
                                newOne.renew = (bool.Parse(supplement.Rows[row][col].ToString()));

                            Debug.WriteLine($"{col} {row}:  {supplement.Rows[row][col]}");
                        }
                        ijs.Add(newOne);
                    }
                    ij.supplement = ijs.ToArray();

                    string output = JsonConvert.SerializeObject(ij);
                    File.WriteAllText(path, output);

                    //foreach (IpsaJsonLibraries lib in ij.libraries)
                    //{
                    //    libs.Rows.Add();
                    //    libs.Rows[libCol][0] = $"{lib.name}";
                    //    libs.Rows[libCol][1] = $"{lib.url}";
                    //    libs.Rows[libCol][2] = $"{lib.size}";
                    //    libs.Rows[libCol][3] = $"{lib.extract}";

                    //    libCol++;
                    //}
                }

                //int libCol = 0;
                //foreach (IpsaJsonLibraries lib in ij.libraries)
                //{
                //    libs.Rows.Add();
                //    libs.Rows[libCol][0] = $"{lib.name}";
                //    libs.Rows[libCol][1] = $"{lib.url}";
                //    libs.Rows[libCol][2] = $"{lib.size}";
                //    libs.Rows[libCol][3] = $"{lib.extract}";

                //    libCol++;
                //}
                //libsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //libsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //libsDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //libsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //if (ij.supplement != null)
                //{
                //    int supCol = 0;
                //    foreach (IpsaJsonSupplement sup in ij.supplement)
                //    {
                //        supplement.Rows.Add();
                //        supplement.Rows[supCol][0] = $"{sup.name}"; //2 (orig pos in json, shouldn't really matter anyways)
                //        supplement.Rows[supCol][1] = $"{sup.path}"; //1
                //        supplement.Rows[supCol][2] = $"{sup.url}"; //0
                //        supplement.Rows[supCol][3] = $"{sup.renew}"; //3

                //        supCol++;
                //    }

                //    supplementDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //    supplementDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //    supplementDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //    supplementDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //}
            }
        }
            private void importIpsaJsonToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = ".JSON files|*.json";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ImportIpsa(dialog.FileName);
                }
            }

            private void exportIpsaJsonToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = ".JSON files|*.json";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ExportIpsa(dialog.FileName);
                }
            }
        }
    }
