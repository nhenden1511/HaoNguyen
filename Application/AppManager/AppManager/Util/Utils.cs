using AppManager.Entity;
using AppManager.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using PCLCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEdit = DevExpress.XtraEditors.TextEdit;

namespace AppManager.Util
{
    public enum ProductType
    {
        Color,
        Size
    }

    public static class Utils
    {
        public static long GetIdFocus(this GridControl grid)
        {
            try
            {
                var col = grid.MainView as ColumnView;
                return (long)col.GetFocusedRowCellValue("Id");
            }
            catch (Exception ex)
            {
                return 0;
            }
            
        }

        public static IList<ProductGroup> LoadGroupToCBB(this ComboBox combobox)
        {
            var _groups = ProductGroupRepository.Instance.GetAll();
            combobox.Items.Clear();

            if (_groups.Count > 0)
            {
                foreach (var item in _groups)
                {
                    combobox.Items.Add(item.Name);
                }
                combobox.SelectedIndex = 0;
            }
            return _groups;
        }

        public static IList<Product> LoadProductToCBB(this ComboBox combobox, long groupId)
        {
            var products = ProductRepository.Instance.GetProductsByGroup(groupId);
            combobox.Items.Clear();
            if (products.Count > 0)
            {
                foreach (var item in products)
                {
                    combobox.Items.Add(item.Name);
                }
                combobox.SelectedIndex = 0;
            }
            return products;
        }

        public static void LoadProductToCBB(this ComboBox combobox, IList<Product> products)
        {
            combobox.Items.Clear();
            if (products.Count > 0)
            {
                foreach (var item in products)
                {
                    combobox.Items.Add(item.Name);
                }
                combobox.SelectedIndex = 0;
            }
        }

        public static string ToCurrency(this TextBox _txtSellPrice, string currency = "")
        {
            long price = 0;
            try
            {
                if (!string.IsNullOrWhiteSpace(currency))
                    price = Convert.ToInt64(currency.Replace(".", ""));
                else
                    price = Convert.ToInt64(_txtSellPrice.Text.Replace(".", ""));
            }
            catch (Exception ex)
            {
                var txt = Regex.Replace(_txtSellPrice.Text, "[^0-9.]", "");
                if(!string.IsNullOrWhiteSpace(txt))
                    price = Convert.ToInt64(txt.Replace(".", ""));
            }
            

            var strPrice = price.ToString();
            var resuilt = "";

            if (strPrice.Length <= 3)
                strPrice += "000";
            var n = strPrice.Length;
            while (n > 0)
            {
                if (n > 3)
                {
                    resuilt = "." + strPrice.Substring(n - 3) + resuilt;
                    strPrice = strPrice.Remove(n - 3, 3);
                }
                else
                {
                    resuilt = strPrice + resuilt;
                }
                n = n - 3;
            }
            _txtSellPrice.Text = resuilt;
            _txtSellPrice.Select(resuilt.Length - 4, 0);
            return resuilt;
        }

        public static string ToCurrency(this int price)
        {
            var strPrice = price.ToString();
            var resuilt = "";

            if (strPrice.Length <= 3)
                strPrice += "000";
            var n = strPrice.Length;
            while (n > 0)
            {
                if (n > 3)
                {
                    resuilt = "." + strPrice.Substring(n - 3) + resuilt;
                    strPrice = strPrice.Remove(n - 3, 3);
                }
                else
                {
                    resuilt = strPrice + resuilt;
                }
                n = n - 3;
            }
            return resuilt;
        }

        public static string ToCurrency(this long price)
        {
            var strPrice = price.ToString();
            var resuilt = "";

            if (strPrice.Length <= 3)
                strPrice += "000";
            var n = strPrice.Length;
            while (n > 0)
            {
                if (n > 3)
                {
                    resuilt = "." + strPrice.Substring(n - 3) + resuilt;
                    strPrice = strPrice.Remove(n - 3, 3);
                }
                else
                {
                    resuilt = strPrice + resuilt;
                }
                n = n - 3;
            }
            return resuilt;
        }

        public static Int32 ToPrice(this TextBox price)
        {
            if (string.IsNullOrWhiteSpace(price.Text)) return 0;
            return Convert.ToInt32(price.Text.Replace(".", ""));
        }
        public static Int32 ToPrice(this string price)
        {
            if (string.IsNullOrWhiteSpace(price)) return 0;
            return Convert.ToInt32(price.Replace(".", ""));
        }

        public static Int32 ToNumber(this TextBox number)
        {
            if (!string.IsNullOrWhiteSpace(number.Text))
            {
                try {
                    return Convert.ToInt32(number.Text);
                }
                catch (Exception ex){}
            }
            return 0;
        }

        public static void SetNumber(this TextBox number, object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static bool IsNull(this TextBox price)
        {
            return string.IsNullOrWhiteSpace(price.Text);
        }
    }

    public static class Identify
    {
        public static Device Device { get; set; }

        public static long Id
        {
            get
            {
                var dateTime = DateTime.Now.ToUniversalTime();
                var julianDate = ToJulian(dateTime);
                var bitmark = GetBitMarkLength(Device.Id);
                long id = Device.Id;
                id = id << 4 - bitmark;
                id |= (uint)Rand(); //maximum 20 bit
                id = id << 16;
                id |= (ushort)julianDate;
                id = id << 5;
                id |= (ushort)dateTime.Hour;
                id = id << 6;
                id |= (ushort)dateTime.Minute;
                id = id << 6;
                id |= (ushort)dateTime.Second;
                id = id << 10;
                id |= (ushort)dateTime.Millisecond;
                return id;
            }
        }

        static int ToJulian(DateTime dateTime)
        {
            int day = dateTime.Day;
            int month = dateTime.Month;
            int year = dateTime.Year;

            if (month < 3)
            {
                month = month + 12;
                year = year - 1;
            }

            return day + (153 * month - 457) / 5 + 365 * year + (year / 4) - (year / 100) + (year / 400);// + 1721119;
        }

        static string FromJulian(long julianDate, string format)
        {
            long L = julianDate + 68569;
            long N = ((4 * L) / 146097);
            L = L - ((146097 * N + 3) / 4);
            long I = ((4000 * (L + 1) / 1461001));
            L = L - ((1461 * I) / 4) + 31;
            long J = ((80 * L) / 2447);
            int Day = (int)(L - ((2447 * J) / 80));
            L = (J / 11);
            int Month = (int)(J + 2 - 12 * L);
            int Year = (int)(100 * (N - 49) + I + L);

            // example format "dd/MM/yyyy"
            return new DateTime(Year, Month, Day).ToString(format);
        }

        static int GetBitMarkLength(long n)
        {
            return Convert.ToString(n, 2).Length;
        }

        static string GetInvert(int n)
        {
            return Convert.ToString(~n, 2);
        }

        static int Rand()
        {
            const int maxValue = 2 ^ 20;

            var buffer = new byte[4];
            int bits, val;

            do
            {
                NetFxCrypto.RandomNumberGenerator.GetBytes(buffer);
                bits = BitConverter.ToInt32(buffer, 0) & 0x7FFFFFFF;
                val = bits % maxValue;
            } while (bits - val + (maxValue - 1) < 0);

            return val;
        }
    }
}
