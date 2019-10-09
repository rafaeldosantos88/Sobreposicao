using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } //TAXA DE JUROS

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = InterestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate; // Vai atualizar o saldo da conta baseado na taxa de juros InteresRate
        }
        public override void withdraw(double amount)
        {
            //Balance -= amount;         Vou descontar do meu saldo a quantia ammount sem a taxa de 5 reais
            base.withdraw(amount);  //Já aqui com a palavrinha base Eu consigo aproveitar a operação da superclasse e fazer mais algumas coisas.
            Balance -= 2.0;
        }
    }
}