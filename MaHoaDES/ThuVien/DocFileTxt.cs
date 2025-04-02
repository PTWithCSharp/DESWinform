using MaHoaDES.BieuMau;
using MaHoaDES.DoiTuong;
using System;
using System.IO;
using System.Windows.Forms;

namespace AOC.ThuVien
{
    class DocFileTxt
    {
        public static ChuoiNhiPhan FileReadToBinary(string filename, frmMaHoaDES.ProgressUpdateCallback progressUpdate)
        {

            try
            {
                ChuoiNhiPhan chuoi;

                ChuoiNhiPhan KQ = new ChuoiNhiPhan(0);
                byte[] fileBytes = File.ReadAllBytes(filename);
                int index = 0;
                foreach (byte b in fileBytes)
                {
                    index++;
                    chuoi = ChuoiNhiPhan.ChuyenSoSangNhiPhan(b, 8);
                    KQ = KQ.Cong(chuoi, progressUpdate, fileBytes.Length * 8);
                    progressUpdate.Invoke($"Xử lý hoàn tất: {index}/{fileBytes.Length} bytes", -1);

                }

                return KQ;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: Đường dẫn File không hợp lệ", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static void WriteBinaryToFile(string filename, ChuoiNhiPhan chuoiVao, frmMaHoaDES.ProgressUpdateCallback progressUpdate)
        {
            byte[] MangByte = new byte[chuoiVao.MangNhiPhan.Length / 8];
            for (int i = 0; i < chuoiVao.MangNhiPhan.Length / 8; i++)
            {
                MangByte[i] = (byte)ChuoiNhiPhan.ChuyenMangSangByte(chuoiVao.MangNhiPhan, i * 8, i * 8 + 8);
            }
            File.WriteAllBytes(filename, MangByte);

        }
    }
}
