using System;

namespace DIO.bank
{
    public class Conta
    {
        private TipoConta TipoConta {get;set;}
        private double Crédito {get;set;}
        private double Saldo {get;set;}
        private string Nome {get;set;}


    public Conta(TipoConta tipoConta, double saldo, double Crédito, string Nome)
    {
        this.TipoConta = tipoConta;
        this.Saldo = saldo;
        this.Crédito = Crédito;
        this.Nome = Nome;
    }


    public bool Sacar(double valorSaque)
    {
        if(this.Saldo - valorSaque < this.Crédito *-1)
        {
            Console.WriteLine("Saldo Insuficiente");
            return false;
        }

        this.Saldo -= valorSaque;

        Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);

        return true; 
    }

    public void Depositar(double valorDeposito)
    {
        this.Saldo += valorDeposito;
        Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
    }
    public void Transferir(double valorTransferencia, Conta contaDestino)
    {
        if (this.Sacar(valorTransferencia))
        {
            contaDestino.Depositar(valorTransferencia);
        }
    }
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + "  |  "; 
            retorno += "Nome " + this.Nome + "  |  "; 
            retorno += "Saldo " + this.Saldo + "  |  "; 
            retorno += "Crédito " + this.Crédito + "  |  "; 
            return retorno;
        }


    }
}