
namespace Exercicio_Interface_Contract.Entities.Service
{
    public interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
