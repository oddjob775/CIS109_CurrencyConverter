using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverter
{
    public partial class CurrencyConvert : Form
    {
        public CurrencyConvert()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?rlz=1C1CHBF_enUS779US779&sxsrf=ALeKk03MKNDuFNkOnCq0q1t05Zt1WZiigg:1594066793096&q=currency+converter&sa=X&ved=2ahUKEwiIl83HubnqAhWUr54KHSjlAvsQ1QIoAHoECAwQAQ&biw=1536&bih=750");
        // lol this should NOT have worked...
        }
    }
}
