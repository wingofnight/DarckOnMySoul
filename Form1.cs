using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarckOnMySoul
{
    public partial class FormPicture : Form
    {
        public string F_name;
        Bitmap bmp;
        public FormPicture()
        {
            InitializeComponent();               
        }

        private void Button_Select_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "C:\\Users\\Public\\Pictures";
            DialogResult result =  openFileDialog.ShowDialog();
            LoadPicture(openFileDialog.FileName);
            F_name = openFileDialog.FileName;
            int size = F_name.Length - 4;
            F_name = F_name.Remove(size, 4);
            btn_accept.Visible = true;
        }
        public void LoadPicture(string filename)
        {
            try
            {
                bmp = new Bitmap(Image.FromFile(filename));
                Picture.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            ChangePicture();            
            Picture.Image.Save(F_name + "-result.jpg");
        }
        public void ChangePicture()
        {
            Bitmap res = new Bitmap(bmp);
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)              
            {
                    Color pixel = bmp.GetPixel(x, y);
                   
                     pixel = ChangeGrayscale(pixel);
                    
                    res.SetPixel(x, y, pixel);
            }
            Picture.Image = res;
        }
        private Color ChangeGrayscale(Color pixel)
        {
            int avg = (pixel.R + pixel.G + pixel.B + 1) / 3;
            return Color.FromArgb(avg, avg, avg);
        }
    }
}
