﻿using ludogame_v4.DuLieu;
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

        private Button btnSapBanCo;

        private Label label1;

        private PictureBox picLuotQC;

        private TheHienXiNgau TheHienXN = new TheHienXiNgau();

        private XiNgau XN = new XiNgau();

        private Button btnTuyChon;

        private Button btnThoat;
        private Colors currentTurn;
        private BanCo BC = new BanCo();

        private TuyChon TuyChonThamSo = new TuyChon();

        private bool bEnter = false;

        public FormXuLyChinh()
        {
            InitializeComponent();
            TheHienXN.UserControlClicked += MyControl_UserControlClicked;
            //panelXN.Controls.Add(TheHienXN);

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

        public void ResetManHinh()
        {
            panelBC.BackgroundImage = new Bitmap(TuyChonThamSo.tc.HinhBanCo);
            //TheHienXN = new TheHienXiNgau();
            TheHienXN.SoXiNgauTheHien = TuyChonThamSo.tc.SoHotXiNgau;
            TheHienXN.DinhViXiNgau();
            //this.panelXN_Red.Controls.Clear();
            //this.panelXN_Blue.Controls.Clear();

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
            picLuotQC.Image = new Bitmap(GetStrImage());
            switch (currentTurn)
            {
                case Colors.Green:
                    XN.DoXingau(TheHienXN, panelXN_Green);
                    panelXN_Green.Controls.Add(TheHienXN);
                    panelXN_Green.BringToFront();
                    break;
                case Colors.Red:
                    XN.DoXingau(TheHienXN, panelXN_Red);
                    panelXN_Red.Controls.Add(TheHienXN);
                    panelXN_Red.BringToFront();
                    break;
                case Colors.Yellow:
                    XN.DoXingau(TheHienXN, panelXN_Yellow);
                    panelXN_Yellow.Controls.Add(TheHienXN);
                    panelXN_Yellow.BringToFront();
                    break;
                case Colors.Blue:
                    XN.DoXingau(TheHienXN, panelXN_Blue);
                    panelXN_Blue.Controls.Add(TheHienXN);
                    panelXN_Blue.BringToFront();
                    break;
                default:

                    break;
            }
            BC.DLBC.CapNhatGTXN(XN);
            bEnter = (KiemTraRaQuan() ? true : false);
            BC.XuLyBanCo();
            if (!bEnter)
            {
                BC.DLBC.UserHienTai = BC.DLBC.UserHienTai % BC.DLBC.SoNguoichoi + 1;
            }
        }



        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            TuyChonThamSo.ShowDialog(this);
            btnSapBanCo.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        LuuDuLieuSql Data = new LuuDuLieuSql();
        private void btnSapBanCo_Click(object sender, EventArgs e)
        {
            panelXN.Controls.Add(TheHienXN);
            ResetManHinh();

            BC.SapBanCo(panelBC, TuyChonThamSo.tc);

            Data.CreateBanSql();
            btnDoXiNgau.Enabled = true;

            isAutoRunning = false;
            HamAuto();
        }

        private bool isAutoRunning = false;
        async void HamAuto()
        {
            isAutoRunning = TuyChonThamSo.KiemTraChoiVoiMay();
            while (isAutoRunning)
            {
                await Task.Delay(1000);
                for (int i = 0; i < TuyChonThamSo.tc.SoMay.Length; i++)
                {
                    if (BC.DLBC.UserHienTai == i + 1 && TuyChonThamSo.tc.SoMay[i] == 1)
                    {
                        {
                            btnDoXiNgau.PerformClick();
                            await Task.Delay(1000);
                            BC.TuDongDiChuyenCacQuan();
                            await Task.Delay(1500);
                        }
                    }

                }
            }


        }

        private void btnRank_Click(object sender, EventArgs e)
        {
           BangXepHang bangXepHang = new BangXepHang();
            bangXepHang.Show(this);
            bangXepHang.ShowData();
        }
    }
}

