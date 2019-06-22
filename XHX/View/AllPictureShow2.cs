using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XHX;
using System.IO;
using XHX.Common;

namespace XHX.View
{
    public partial class AllPictureShow2 : DevExpress.XtraEditors.XtraForm
    {
        localhost.Service service = new XHX.localhost.Service();
        string _filePath = "";
        string[] _fileName = null; 
        string _shopName = "";
        string _subjectCode="";
        string _type="";
        string _code = "";
        int _maxLen = 1;

        public AllPictureShow2()
        {
            InitializeComponent();

            this.Shown += new EventHandler(AllPictureShow2_Shown);
        }

        void AllPictureShow2_Shown(object sender, EventArgs e)
        {
            this.kpImageViewer1.FitToScreen();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param>
        /// <param name="shopName"></param>
        /// <param name="subjectCode"></param>
        /// <param name="type"></param>
        /// <param name="code"></param>
        public AllPictureShow2(string filePath, string[] fileName, string shopName, string subjectCode, string type, string code)
            : this()
        {
            this.LookAndFeel.SetSkinStyle(CommonHandler.Skin_Name);
             _filePath = filePath;
             _fileName = fileName;
             _shopName = shopName;
             _subjectCode = subjectCode;
             _type = type;
             _code = code;
             _maxLen = fileName.Length;
             lblCurrent.Text = "1";
             lblSum.Text = fileName.Length.ToString();// CalEndIndex(1).ToString();
             PictureShowFive(filePath, fileName, shopName, subjectCode, type, code, 1);

        }
        public void PictureShowFive(string filePath, string[] fileName, string shopName, string subjectCode, string type, string code, int startIndex)
        {
            List<Image> pictures = new List<Image>();

            //for (int i = startIndex - 1; i < endIndex; i++)
            //{
                byte[] bytes = null;
                if (type == "SpecialCase" || type == "Notice")
                {
                    bytes = service.SearchAnswerDtl2Pic(fileName[startIndex-1], shopName, subjectCode, type, code);
                }
                else
                {
                    bytes = service.SearchAnswerDtl2Pic(fileName[startIndex-1].Replace(".jpg", ""), shopName, subjectCode, type, code);
                }
                if (bytes != null && bytes.Length != 0)
                {
                    MemoryStream ms = new MemoryStream(bytes);
                    Image image = Image.FromStream(ms);
                    pictures.Add(image);
                    lblWarn.Text = "";
                }
                else {
                    lblWarn.Text = "无照片";
                }
            //}

            if (pictures.Count != 0)
            {
                this.kpImageViewer1.ImageList = pictures;

            }
            else
            {
                //for (int i = 0; i < fileName.Length; i++)
                //{
                //    if (type != "SpecialCase")
                //    {
                //        if (File.Exists(filePath + fileName[i] + ".jpg"))
                //        {
                //            Image image = Image.FromFile(filePath + fileName[i] + ".jpg");
                //            pictures.Add(image);
                //        }
                //    }
                //    else
                //    {
                //        if (File.Exists(filePath + fileName[i]))
                //        {

                //            Image image = Image.FromFile(filePath + fileName[i]);
                //            pictures.Add(image);
                //        }
                //    }
                //}
                this.kpImageViewer1.Image = Properties.Resources.imgWarning;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblCurrent.Text) == 1)
            {
                return;
            }
            PictureShowFive(_filePath, _fileName, _shopName, _subjectCode, _type, _code, Convert.ToInt32(lblCurrent.Text) - 1);
            lblCurrent.Text = (Convert.ToInt32(lblCurrent.Text) -1).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblCurrent.Text) == _fileName.Length)
            {
                return;
            }
            PictureShowFive(_filePath, _fileName, _shopName, _subjectCode, _type, _code, Convert.ToInt32(lblCurrent.Text) + 1);
            lblCurrent.Text = (Convert.ToInt32(lblCurrent.Text) + 1).ToString();
        }

    }
}
