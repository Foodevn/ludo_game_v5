using ludogame_v4.XuLy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ludogame_v4.DuLieu
{
    public class DuLieuBanCo
    {
        private int nUsers; // Số người 

        private int UserHH;

        private int nOco; // Số ô trên bàn cờ

        public int[] arrBC;

        public int SoXN;

        public int gtXN1; // Giá tri 1 xí ngầu 

        public int gtXN2; // Giá tri 2 xí ngầu 

        public int gtRQ1; // Giá tri ra quân = 1, = 6 thì đi

        public int gtRQ2;

        public int gtVD1;// Giá tri về đích = 1, = 6 thì đi

        public int gtVD2;

        public ArrayList arrUsers = new ArrayList();

        public ArrayList arrVTChuong = new ArrayList();

        public string Hinh;

        public int UserHienTai
        {
            get
            {
                return UserHH;
            }
            set
            {
                UserHH = value;
            }
        }

        public int SoNguoichoi
        {
            get
            {
                return nUsers;
            }
            set
            {
                nUsers = value;
            }
        }

        public int SoOBc
        {
            get
            {
                return nOco;
            }
            set
            {
                nOco = value;
            }
        }

        public string HinhBanCo
        {
            get
            {
                return Hinh;
            }
            set
            {
                Hinh = value;
            }
        }

        public DuLieuBanCo()
        {
            SoOBc = 56;
            SoNguoichoi = 4;
            UserHienTai = 1;
            HinhBanCo = Application.StartupPath + "/HinhBanCo/BanCo1.bmp";
            InitArrBC();
            KhoiTao();
        }

        public DuLieuBanCo(int n, int iUser)
        {
            SoOBc = 56;
            SoNguoichoi = n;
            UserHienTai = iUser;
            HinhBanCo = Application.StartupPath + "/HinhBanCo/BanCo1.bmp";
            InitArrBC();
            KhoiTao();
        }

        public DuLieuBanCo(DuLieuTuyChon tc)
        {
            SoOBc = 56;
            SoNguoichoi = tc.SoNguoiChoi;
            UserHienTai = tc.NguoiUuTien;
            HinhBanCo = Application.StartupPath + "/HinhBanCo/BanCo1.bmp";
            InitArrBC();
            KhoiTao(tc.SoNguaQuan);
        }

        public void KhoiTaoMangVeDich(int iUser, DuLieuUser User)
        {
            int num = 33;  // Khoảng cách giữa các ô
            int num2 = 6; // Số ô về đích không đổi
            if (iUser == 0)
            {
                Point point = new Point((int)(224 * 1.2805), (int)(388 * 1.25));
                for (int i = 0; i < num2; i++)
                {
                    int y = point.Y + -num * i;
                    ref Point reference = ref User.arrVtDich[i];
                    reference = new Point(point.X, y);
                }
            }
            if (iUser == 1)
            {
                Point point = new Point((int)(395 * 1.25), (int)(222 * 1.2805));
                for (int i = 0; i < num2; i++)
                {
                    int y = point.X + -num * i;
                    ref Point reference2 = ref User.arrVtDich[i];
                    reference2 = new Point(y, point.Y);
                }
            }
            if (iUser == 2)
            {
                Point point = new Point((int)(224 * 1.2805), (int)(50 * 1.31));
                for (int i = 0; i < num2; i++)
                {
                    int y = point.Y + num * i;
                    ref Point reference3 = ref User.arrVtDich[i];
                    reference3 = new Point(point.X, y);
                }
            }
            if (iUser == 3)
            {
                Point point = new Point((int)(58 * 1.31), (int)(222 * 1.2805));
                for (int i = 0; i < num2; i++)
                {
                    int y = point.X + num * i;
                    ref Point reference4 = ref User.arrVtDich[i];
                    reference4 = new Point(y, point.Y);
                }
            }
        }

        public void KhoiTaoMangChuong()
        {
            //Blue
            Point point = new Point(423 + 120, 406 + 110);
            arrVTChuong.Add(point);
            //Red
            point = new Point(420 +120 , 38);
            arrVTChuong.Add(point);
            //Yellow
            point = new Point(30, 38);
            arrVTChuong.Add(point);
            //Green
            point = new Point(30, 406 + 110);
            arrVTChuong.Add(point);
        }

        public void KhoiTao(int[] SoQN)
        {
            for (int i = 0; i < SoNguoichoi; i++)
            {
                DuLieuUser duLieuUser = new DuLieuUser(SoQN[i]);
                KhoiTaoMangVeDich(i, duLieuUser);
                arrUsers.Add(duLieuUser);
            }
            KhoiTaoMangChuong();
        }

        public void KhoiTao()
        {
            for (int i = 0; i < SoNguoichoi; i++)
            {
                DuLieuUser duLieuUser = new DuLieuUser(4);
                KhoiTaoMangVeDich(i, duLieuUser);
                arrUsers.Add(duLieuUser);
            }
            KhoiTaoMangChuong();
        }

        public void CapNhatDL(DuLieuTuyChon tc)
        {
            arrUsers.Clear();
            arrVTChuong.Clear();
            SoNguoichoi = tc.SoNguoiChoi;
            UserHienTai = tc.NguoiUuTien;
            gtRQ1 = tc.gtRaQuan1;
            gtRQ2 = tc.gtRaQuan2;
            gtVD1 = tc.gtVeDich1;
            gtVD2 = tc.gtVeDich2;
            KhoiTao(tc.SoNguaQuan);
        }

        public void CapNhatGTXN(XiNgau xn)
        {
            SoXN = xn.SoXN;
            if (SoXN == 1)
            {
                gtXN1 = xn.gt1;
                return;
            }
            gtXN1 = xn.gt1;
            gtXN2 = xn.gt2;
        }

        public void InitArrBC()
        {
            arrBC = new int[SoOBc];
            for (int i = 0; i < SoOBc; i++)
            {
                arrBC[i] = 0;
            }
        }

        public int LayGiaTriXN()
        {
            if (SoXN == 1)
            {
                return gtXN1;
            }
            return gtXN1 + gtXN2;
        }
    }
}
