using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
   public partial class Form1 : Form
    {
        private enum Channel
        {
            R = 0, G = 1, B = 2
        }

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cmbChannel.DataSource = Enum.GetNames(typeof(Channel));
            const string url = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg?resize=750px:*";
            pbSource.Load(url);
            SetChannel(GetSelectedChannel());
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                pbSource.Image = new Bitmap(ofd.FileName);
                SetChannel(GetSelectedChannel());
            }
        }

        private void SetChannel(Channel channel)
        {
            var ia = new ImageAttributes();
            var m = new ColorMatrix();
            var el = new float[][] {
                new float[] { 0, 0, 0, 0, 0},
                new float[] { 0, 0, 0, 0, 0},
                new float[] { 0, 0, 0, 0, 0},
                new float[] { 0, 0, 0, 1, 0},
                new float[] { 0, 0, 0, 0, 0},
            };
            el[(int)channel][(int)channel] = 1;
            m = new ColorMatrix(el);
            var bmp = new Bitmap(pbSource.Image.Width, pbSource.Image.Height);
            using (var g = Graphics.FromImage(bmp))
            {
                ia.ClearColorMatrix();
                ia.SetColorMatrix(m, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(pbSource.Image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, ia);
            }
            pbDest.Image = bmp;
        }

        private Channel GetSelectedChannel()
        {
            return (Channel)Enum.GetValues(typeof(Channel)).GetValue(cmbChannel.SelectedIndex);
        }

        private void cmbChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pbSource.Image == null)
            {
                return;
            }
            SetChannel(GetSelectedChannel());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pbSource.Image == null)
            {
                return;
            }
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png|BMP|*.bmp";
                sfd.FilterIndex = 3;
                var imageFormat = ImageFormat.Bmp;
                switch (sfd.FilterIndex)
                {
                    case 1:
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case 2:
                        imageFormat = ImageFormat.Png;
                        break;
                }
                sfd.FileName = System.IO.Path.GetFullPath($"{GetSelectedChannel().ToString()}_channel");
                if (sfd.ShowDialog() == DialogResult.Cancel) return;
                pbDest.Image.Save(sfd.FileName, imageFormat);
            }
        }
    }
}
