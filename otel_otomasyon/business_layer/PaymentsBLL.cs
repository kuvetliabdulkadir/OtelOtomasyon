using otel_otomasyon.dataaccess_layer;
using otel_otomasyon.entity_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.business_layer
{
    public class PaymentsBLL
    {
        private  PaymentsDAL _paymentsDAL;

        public PaymentsBLL()
        {
            _paymentsDAL = new PaymentsDAL();
        }

        public bool AddPayment(Payments payment)
        {
            return _paymentsDAL.AddPayment(payment);
        }

        public DataTable GetPayment()
        {
            return _paymentsDAL.GetPayment();
        }

        public PaymentDetailsViewModel GetPaymentDetails(int paymentID)
        {
            return _paymentsDAL.GetPaymentDetails(paymentID);
        }

    }

}
