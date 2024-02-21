using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using Newtonsoft.Json;
using System.Net.Http;

namespace GestionMagasins
{

    public partial class frmFournisseur1 : Form
    {
        dbContextDataContext db = new dbContextDataContext();
        //private string A;
        DialogResult dr = new DialogResult();
        OpenFileDialog opd = new OpenFileDialog();
        private string a;



        public frmFournisseur1(string a)
        {

            InitializeComponent();
            this.a = a;
        }

        private void frmFournisseur1_Load(object sender, EventArgs e)
        {

            if (a != null)
            {
                Magasin1 d = new Magasin1();
                Fournisseur R = db.Fournisseur.FirstOrDefault(m => m.Id_four == Int32.Parse(a));
                txtNom.Text = R.Nom_four;
                
                txtCin.Text = R.Cin.ToString();
                txtTel.Text = R.Tel.ToString();
                txtEmail.Text = R.Email;
                txtDate.Text = R.Delai_livraison.ToString();
                txtPays.Text = R.Pays;
                txtville.Text = R.Ville;
                txtAdresse.Text = R.Adresse;
                txtnum.Text = R.N_Fournisseur.ToString();


                FetchAsync();
                FetchAsync2();


            }
            else
            {
                int idcom = db.bon_commande.Any() ? db.Fournisseur.Max(x => x.Id_four) + 1 : 1;
                txtnum.Text = "FRN-000" + idcom.ToString();
            }
            FetchAsync();
            FetchAsync2();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
              

                //ajouter un colone dans le tableau et base de donnees   
                //  InsertOnSubmit créé et ajouté à un colone au base de données
                // SubmitChanges pour enregistrer les modifications  dans une base de donnees
                // donne à id la aleur de Id_resp

                Fournisseur R = new Fournisseur();
              

                R.Nom_four = txtNom.Text;
               
                R.Cin = txtCin.Text;


                R.Delai_livraison = txtDate.DateTime;

                R.Ville = txtville.Text;
                R.Adresse = txtAdresse.Text;
                string tel = txtTel.Text;
                Regex regex = new Regex(@"^\d{10}$");
                if (regex.IsMatch(tel))
                {
                    R.Tel = Int32.Parse(tel);
                }
                else
                {
                    MessageBox.Show("le numero de telephone est incorrect", "erreur");
                }
                string Gmail = txtEmail.Text;
                Regex regex1 = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                if (regex1.IsMatch(Gmail))
                {
                    R.Email = Gmail;
                }
                else
                {
                    MessageBox.Show("Gmail  est incorrect", "erreur");
                }
                R.N_Fournisseur = txtnum.Text ;
               
                R.Pays = txtPays.SelectedItem.ToString();
                R.Ville = txtville.SelectedItem.ToString();


                a = R.Id_four.ToString();
                //txtnum.Text = "FRN" + a;
                if (string.IsNullOrEmpty(txtNom.Text))
                {
                    MessageBox.Show("Entrer le nom de fournisseur:", "Information");
                    txtNom.Focus();
                    return;
                }
                db.Fournisseur.InsertOnSubmit(R);





                db.SubmitChanges();
                MessageBox.Show("Le fournisseur a été ajouté avec succès.", "Information");

            }
            else
            
            {
                // modifier 


                Fournisseur R = db.Fournisseur.FirstOrDefault(m => m.Id_four == Int32.Parse(a));
                R.Nom_four = txtNom.Text;
             
                R.Cin = txtCin.Text;


                R.Delai_livraison = txtDate.DateTime;

                R.Ville = txtville.Text;
                R.Adresse = txtAdresse.Text;
                string tel = txtTel.Text;
                Regex regex = new Regex(@"^\d{10}$");
               
                string Gmail = txtEmail.Text;
                Regex regex1 = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                if (regex1.IsMatch(Gmail) && regex.IsMatch(tel))
                {
                    R.Tel = Int32.Parse(tel);
                    R.Email = Gmail;
                    R.Pays = txtPays.SelectedItem.ToString();
                    R.Ville = txtville.SelectedItem.ToString();

                    db.SubmitChanges();
                    MessageBox.Show("le responsable est modifié", "Information");
                }
                else
                {
                    MessageBox.Show("verifier les données", "erreur");
                }
               
              
            }
            Close();

        }

        //private async void fetshAsync()
        //{





        //        using (var client = new HttpClient())
        //        {
        //            var response = await client.GetAsync("https://countriesnow.space/api/v0.1/countries");

        //            var json = await response.Content.ReadAsStringAsync();
        //            var result = JsonConvert.DeserializeObject<ApiResponse>(json);
        //            txtPays.Properties.Items.AddRange(result.data.Select(c => c.country).ToArray());


        //    }






        //}
        private async Task FetchAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://countriesnow.space/api/v0.1/countries");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<ApiResponse>(json);
                        txtPays.Properties.Items.AddRange(result.data.Select(c => c.country).ToArray());
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }





        //private async void fetshAsync2()
        //{
        //    var selectedCountry = (string)txtPays.SelectedItem;



        //    using (var client = new HttpClient())
        //    {
        //        var response = await client.GetAsync($"https://countriesnow.space/api/v0.1/countries?country={selectedCountry}");

        //            var json = await response.Content.ReadAsStringAsync();
        //            var result = JsonConvert.DeserializeObject<ApiResponse>(json);


        //            var cities = result.data.FirstOrDefault(c => c.country == selectedCountry)?.cities;

        //            if (cities != null)
        //            {
        //                txtville.Properties.Items.Clear();
        //                txtville.Properties.Items.AddRange(cities.ToArray());
        //            }





        //    }

        //}
        private async Task FetchAsync2()
        {
            try
            {
                var selectedCountry = (string)txtPays.SelectedItem;

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"https://countriesnow.space/api/v0.1/countries?country={selectedCountry}");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<ApiResponse>(json);

                        var cities = result.data.FirstOrDefault(c => c.country == selectedCountry)?.cities;

                        if (cities != null)
                        {
                            txtville.Properties.Items.Clear();
                            txtville.Properties.Items.AddRange(cities.ToArray());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }






        private void txtPays_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FetchAsync2();
            txtville.EditValue = "";
        }
    }
}
