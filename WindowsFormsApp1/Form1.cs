using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisLog
{
    public partial class FormGirisSayfasi : Form
    {
        public FormGirisSayfasi()
        {
            InitializeComponent();
        }

        FileStream fileStream = new FileStream(@"Giris Log.txt", FileMode.Append, FileAccess.Write);

        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            StreamWriter streamWriter = new StreamWriter(fileStream);

            try
            {
                if (txtKullaniciAdi.Text.Trim() == "")
                {
                    throw new DeficientDataException("Eksik bilgi girildi.");
                }

                streamWriter.WriteLine(txtKullaniciAdi.Text.Trim() + "/" + DateTime.Now.ToString());
                

            }
            catch (DeficientDataException exception)
            {
                MessageBox.Show(exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch 
            {
                MessageBox.Show("Bir hata oluştu tekrar deneyin.","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                streamWriter.Flush();
                txtKullaniciAdi.Text = null;
            }
        }

       
    }
}
