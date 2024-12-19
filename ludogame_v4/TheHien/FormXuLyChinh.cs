using ludogame_v4.DuLieu;
using ludogame_v4.login;
using ludogame_v4.XuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ludogame_v4.TheHien
{
    public enum Colors
    {
        Green,
        Red,
        Yellow,
        Blue
    }

    public partial class FormXuLyChinh : Form
    {
        private Panel panelBC;

        private Button btnDoXiNgau;

        private Label label1;

        private PictureBox picLuotQC;

        private TheHienXiNgau TheHienXN = new TheHienXiNgau();

        private XiNgau XN = new XiNgau();
        private Colors currentTurn;
        private BanCo BC;

        private TuyChon TuyChonThamSo;

        private bool isAutoRunning = false;

        LuuDuLieuSql Data = new LuuDuLieuSql();

        PictureBox icoLocal = new PictureBox();
        public FormXuLyChinh(TuyChon tuyChonThamSo)
        {
            TuyChonThamSo = tuyChonThamSo;

            InitializeComponent();
            //TheHienXN.UserControlClicked += MyControl_UserControlClicked;
            //panelXN.Controls.Add(TheHienXN);
            TheHienXN.Size = new Size((int)(TheHienXN.Width * 2), (int)(TheHienXN.Height * 2));
            TheHienXN.picXN1.Size = new Size((int)(TheHienXN.picXN1.Width * 3), (int)(TheHienXN.picXN1.Height * 3));
            TheHienXN.picXN2.Size = new Size((int)(TheHienXN.picXN2.Width * 3), (int)(TheHienXN.picXN2.Height * 3));

            icoLocal.Size = new Size(50, 50);
            icoLocal.Location = new Point(10, 10);
            icoLocal.SizeMode = PictureBoxSizeMode.StretchImage;
            icoLocal.Image = new Bitmap(Application.StartupPath + "\\image\\iconLocal.png");
        }

        private void MyControl_UserControlClicked(object sender, EventArgs e)
        {
            btnDoXiNgau.Enabled = true;
            btnDoXiNgau.PerformClick();
        }

        private void XuLyChinh_Load(object sender, EventArgs e)
        {
            //LoadHinhBC();
            XN.SoXN = TuyChonThamSo.tc.SoHotXiNgau;
            btnDoXiNgau.Enabled = false;
            //label4.Visible = false;
            //label5.Visible = false;
            TheHienXN.picXN1.Visible = false;
            SapBanCo();
            // CreateMenu();

        }

        public void LoadHinhBC()
        {
            panelBC.BackgroundImage = new Bitmap(TuyChonThamSo.tc.HinhBanCo);
        }
        public string GetStrImage()
        {
            string text = Application.StartupPath + "/hinhngua/";
            switch (BC.DLBC.UserHienTai)
            {
                case 1:
                    text += "duong.gif";
                    currentTurn = Colors.Blue;
                    break;
                case 2:
                    text += "do.gif";
                    currentTurn = Colors.Red;
                    break;
                case 3:
                    text += "vang.gif";
                    currentTurn = Colors.Yellow;
                    break;
                case 4:
                    text += "xanh.gif";
                    currentTurn = Colors.Green;
                    break;
            }
            return text;
        }

        public void GetPlayerNames()
        {
            switch (BC.DLBC.UserHienTai)
            {
                case 1:
                    lbTextNameUser.Text = TuyChonThamSo.tc.PlayerNames[0];

                    break;
                case 2:
                    lbTextNameUser.Text = TuyChonThamSo.tc.PlayerNames[1];

                    break;
                case 3:
                    lbTextNameUser.Text = TuyChonThamSo.tc.PlayerNames[2];

                    break;
                case 4:
                    lbTextNameUser.Text = TuyChonThamSo.tc.PlayerNames[3];
                    break;
            }
        }

        public void GetComments()
        {
            //label4.Visible = true;
            //label5.Visible = true;
            if (BC.KiemTraNguoiChoiDiDc())
                lbComments.Text = "Di chuyển";
            else
                lbComments.Text = "Hết lượt";

            //if (true)
            //    lbComments.Text = "Ném lại";

        }

        public void ResetManHinh()
        {
            panelBC.BackgroundImage = new Bitmap(TuyChonThamSo.tc.HinhBanCo);

            TheHienXN.SoXiNgauTheHien = TuyChonThamSo.tc.SoHotXiNgau;
            TheHienXN.DinhViXiNgau2();
            BC = new BanCo();

            BC.DLBC.CapNhatDL(TuyChonThamSo.tc);
        }

        public bool KiemTraRaQuan()
        {
            if (XN.SoXN == 1)
            {
                if (XN.gt1 == BC.DLBC.gtRQ1 || XN.gt1 == BC.DLBC.gtRQ2)
                {
                    return true;
                }
            }
            else if ((XN.gt1 == BC.DLBC.gtRQ1 && XN.gt2 == BC.DLBC.gtRQ1) || (XN.gt1 == BC.DLBC.gtRQ2 && XN.gt2 == BC.DLBC.gtRQ2))
            {
                return true;
            }
            return false;
        }

        private void btnDoXiNgau_Click(object sender, EventArgs e)
        {
            //picLuotQC.Image = new Bitmap(GetStrImage());
            picLuotQC.Image = new Bitmap(new Bitmap(GetStrImage()), (int)(picLuotQC.Width * 0.7), (int)(picLuotQC.Width * 0.7));
            TheHienXN.picXN1.Visible = true;
            GetPlayerNames();
            XN.DoXingau(TheHienXN);
            ViTriNguoiChoi();
            BC.DLBC.CapNhatGTXN(XN);

            BC.XuLyBanCo();

            btnDoXiNgau.Enabled = false;
           
            GetComments();
            BC.DLBC.RollCLick += DLBC_RollCLick;
            if (BC.KiemTraNguoiChoiDiDc() == false) // Có đi dc không, nếu không thì chuyển User tiếp thep
            {
                //UserNext();
                btnNext.Visible = true;
                btnDoXiNgau.Enabled = false;
            }
        }


        void ViTriNguoiChoi()
        {
            GetStrImage();  
            switch (currentTurn)
            {
                case Colors.Green:
                    panelXN_Green.Controls.Add(icoLocal);
                    panelXN_Green.BringToFront();
                    break;
                case Colors.Red:
                    panelXN_Red.Controls.Add(icoLocal);
                    panelXN_Red.BringToFront();
                    break;
                case Colors.Yellow:

                    panelXN_Yellow.Controls.Add(icoLocal);
                    panelXN_Yellow.BringToFront();
                    break;
                case Colors.Blue:
                    panelXN_Blue.Controls.Add(icoLocal);
                    panelXN_Blue.BringToFront();
                    break;
                default:
                    break;
            }

        }
        private void DLBC_RollCLick(object sender, EventArgs e)
        {         
            if (KiemTraRaQuan())
            {
                btnDoXiNgau.Enabled = true;
            }
            else
            {
                btnDoXiNgau.Enabled = true;
                btnNext.Visible = true;
                //label4.Visible = true;
                //label5.Visible = true;
                btnDoXiNgau.Enabled = false;
                lbComments.Text = "Hết lượt";
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UserNext();       
            picLuotQC.Image = new Bitmap(new Bitmap(GetStrImage()), (int)(picLuotQC.Width * 0.7), (int)(picLuotQC.Width * 0.7));
            TheHienXN.picXN1.Visible = false;
            lbComments.Text = "";
            btnDoXiNgau.Enabled = true;
            btnNext.Visible = false;
            //label4.Visible = false;
            //label5.Visible = false;

        }

        void UserNext()
        {
            BC.DLBC.UserHienTai = BC.DLBC.UserHienTai % BC.DLBC.SoNguoichoi + 1;
            ViTriNguoiChoi();
        }




        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }


        private void SapBanCo()
        {
            panelXN.Controls.Add(TheHienXN);
            ResetManHinh();
            BC.SapBanCo(panelBC, TuyChonThamSo.tc);
            panelXN.BringToFront();

            Data.CreateBanSql();

            btnDoXiNgau.Enabled = true;
            TatHanAuto();
            isAutoRunning = TuyChonThamSo.KiemTraChoiVoiMay();
            if (isAutoRunning)
                HamAuto();

            else
                TatHanAuto();
        }

        private Timer timer = null;
        void HamAuto()
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 2500;
                timer.Tick += Timer_Tick;
            }
            timer.Start();
        }
        void TatHanAuto()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Tick -= Timer_Tick;
                timer.Dispose();
                timer = null;
            }
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            //await Task.Delay(500);
            for (int i = 0; i < TuyChonThamSo.tc.SoMay.Length; i++)
            {
                if (BC.DLBC.UserHienTai == i + 1 && TuyChonThamSo.tc.SoMay[i] == 1)
                {
                    {
                        btnDoXiNgau.PerformClick(); // Gọi lệnh đỗ Xúc sắc
                        await Task.Delay(400);
                        BC.TuDongDiChuyenNguoiChoi();
                        if (btnNext.Visible)
                        {
                            btnNext.PerformClick();
                        }
                        await Task.Delay(1300);
                    }
                }
            }
        }

    }
}

