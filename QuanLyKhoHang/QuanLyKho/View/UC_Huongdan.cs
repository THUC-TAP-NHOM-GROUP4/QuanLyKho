using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.View
{
    public partial class UC_Huongdan : UserControl
    {
        public UC_Huongdan()
        {
            InitializeComponent();
        }

        private void UC_Huongdan_Load(object sender, EventArgs e)
        {
            richTextBox1.Text =
                                     "(1) \t\t\tNHẬP HÀNG: Vào mục Nhập hàng: \n"
                                   + "  Xem danh sách:\n"
                                   + "  Thêm hàng mới: \n"
                                   + "      o Chọn thêm mới => Nhập thông tin vào phiếu\n"
                                   + "      => Click Thêm\n"
                                   + "      => Hoặc thoát\n"
                                   + "               => Nhập thông tin chi tiết cho phiếu nhập\n"
                                   + "                           => Clck thêm\n"
                                   + "                           => Hoặc thoát\n"
                                   
                                   + "(2) \t\t\tPHIẾU XUẤT: Vào mục phiếu xuất: \n"
                                   + "  Xem danh sách:\n"
                                   + "  Thêm mới: \n"
                                   + "      o Nhập thông tin vào phiếu\n"
                                   + "      => Click Thêm\n"
                                  
                                   + "  Xuất hàng:\n"
                                  
                                   + "      o Xác nhận đối tượng\n"
                                   + "      => Xuất hàng.\n"
                                   + " 	Hủy:\n"
                                   + "      o Chọn dòng có đối tượng cần hủy => Click hủy\n"
                                   + "      => Xác nhận thông tin xóa\n"
                                   + "      => Hoặc thoát \n"
                                   + "(3) \t\t\tTHỐNG KÊ: Vào mục phiếu xuất: \n"
                                   + "      o Thống kê nhập xuất theo tháng\n"
                                   + "      o Thống kê nhập xuất theo năm\n\n\n"
                                   + " Mọi thắc mắc xin gửi về hòm thư admin_group4@gmail.com\n";
        }
    }
}
