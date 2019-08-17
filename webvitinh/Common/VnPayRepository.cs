using Microsoft.IdentityModel.Protocols;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using webvitinh.Models;

namespace Common
{
    public class VnPayRepository
    {
        // get data when checkout success !^^
        //Tải code demo tại: https://goo.gl/6SVHAU

        private static readonly ILog log =
                  LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void btnPay_Click(object sender, EventArgs e)
        {
            //Get Config Info
            string vnp_Returnurl = ConfigurationManager.AppSettings["vnp_Returnurl"]; //URL nhan ket qua tra ve 
            string vnp_Url = ConfigurationManager.AppSettings["vnp_Url"]; //URL thanh toan cua VNPAY 
            string vnp_TmnCode = ConfigurationManager.AppSettings["vnp_TmnCode"]; //Ma website
            string vnp_HashSecret = ConfigurationManager.AppSettings["vnp_HashSecret"]; //Chuoi bi mat
            if (string.IsNullOrEmpty(vnp_TmnCode) || string.IsNullOrEmpty(vnp_HashSecret))
            {
                lblMessage.Text = "Vui lòng cấu hình các tham số: vnp_TmnCode,vnp_HashSecret trong file web.config";
                return;
            }
            //Get payment input
            Order order = new Order();
            //Save order to db
            order.OrderId = DateTime.Now.Ticks;
            order.Amount = Convert.ToInt64(txtAmount.Text);
            order.OrderDesc = txtOrderDesc.Text;
            order.CreatedDate = DateTime.Now;
            string locale = cboLanguage.SelectedItem.Value;
            //Build URL for VNPAY
            VnPayLibrary vnpay = new VnPayLibrary();

            vnpay.AddRequestData("vnp_Version", "2.0.0");
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", (order.Amount * 100).ToString());
            //if (cboBankCode.SelectedItem != null && !string.IsNullOrEmpty(cboBankCode.SelectedItem.Value))
            //{
            //    vnpay.AddRequestData("vnp_BankCode", cboBankCode.SelectedItem.Value);
            //}
            vnpay.AddRequestData("vnp_CreateDate", order.CreatedDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_IpAddr", Utils.GetIpAddress());


            if (!string.IsNullOrEmpty(locale))
            {
                vnpay.AddRequestData("vnp_Locale", locale);
            }
            else
            {
                vnpay.AddRequestData("vnp_Locale", "vn");
            }
            vnpay.AddRequestData("vnp_OrderInfo", order.OrderDesc);
            vnpay.AddRequestData("vnp_OrderType", orderCategory.SelectedItem.Value); //default value: other
            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", order.OrderId.ToString());

            string paymentUrl = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);
            log.InfoFormat("VNPAY URL: {0}", paymentUrl);
            Response.Redirect(paymentUrl);
        }
    }
}
