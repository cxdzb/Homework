using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Tip
    {
        //定义一个输入值和两个输出值
        public string BillAmount { get; set; }
        public string TipAmount { get; set; }
        public string TotalAmount { get; set; }

        public Tip()
        {
            //初始化，置空
            this.BillAmount = String.Empty;
            this.TipAmount = String.Empty;
            this.TotalAmount = String.Empty;
        }

        //用于计算的方法
        public void CalculateTip(string originalAmount, double tipPercentage)
        {
            //默认值
            double billAmount = 0.0;
            double tipAmount = 0.0;
            double totalAmount = 0.0;

            if (double.TryParse(originalAmount.Replace('￥', ' '), out billAmount))
            {
                //计算步骤
                tipAmount = billAmount * tipPercentage;
                totalAmount = billAmount + tipAmount;
            }

            this.BillAmount = String.Format("{0:C}", billAmount);
            this.TipAmount = String.Format("{0:C}", tipAmount);
            this.TotalAmount = String.Format("{0:C}", totalAmount);
        }
    }
}
