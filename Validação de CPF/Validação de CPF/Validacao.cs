namespace Validação_de_CPF
{
    internal class Validacao
    {
        public Validacao()
        {
        }

        public int[] CPF(int CPF)
        {
            int[] cpf = new int[9];

            cpf[0] = (CPF / 100000000);
            cpf[1] = (CPF / 10000000) % 10;
            cpf[2] = (CPF / 1000000) % 10;
            cpf[3] = (CPF / 100000) % 10;
            cpf[4] = (CPF / 10000) % 10;
            cpf[5] = (CPF / 1000) % 10;
            cpf[6] = (CPF / 100) % 10;
            cpf[7] = (CPF / 10) % 10;
            cpf[8] = (CPF / 1) % 10;

            return cpf;
        }

        public int DigitoUm(int valor)
        {
            int digito = 0;

            int[] cpf = CPF(valor);
            int[] valores = new int[9];
            int soma = 0;
            
            for(int i = 0; i < 9; i++)
            {
                valores[i] = cpf[i] * ((i - 10)*(-1));
            }

            for(int i = 0;i < 9; i++)
            {
                soma += valores[i];
            }


            int resto = soma % 11;

            if(resto < 2)
            {
                digito = 0;
            }
            else
            {
                digito = 11 - resto;
            }

            return digito;
        }

        public int DigitoDois(int valor)
        {
            int[] aux1 = CPF(valor);
            int aux2 = DigitoUm(valor);
            int soma = 0;
            int digito = 0;

            int[] cpf = new int[10];
            int[] valores = new int[10];

            for (int i = 0; i < 9; i++)
            {
                cpf[i] = aux1[i];
            }
            cpf[9] = aux2;

            for (int i = 0; i < 10; i++)
            {
                valores[i] = cpf[i] * ((i - 11) * (-1));
            }

            for (int i = 0; i < 10; i++)
            {
                soma += valores[i];
            }


            int resto = soma % 11;

            if (resto < 2)
            {
                digito = 0;
            }
            else
            {
                digito = 11 - resto;
            }

            return digito;
        }

        public string UF(int valor)
        {
            string uf = "";

            switch (valor)
            {
                case 0:
                    uf = "RS";
                    break;
                case 1:
                    uf = "DF, GO, MS, TO";
                    break;
                case 2:
                    uf = "PA, AM, AC, AM, RO, RR";
                    break;
                case 3:
                    uf = "CE, MA, PI";
                    break;
                case 4:
                    uf = "PE, RN, PB, AL";
                    break;
                case 5:
                    uf = "BA, SE";
                    break;
                case 6:
                    uf = "MG";
                    break;
                case 7:
                    uf = "RJ, ES";
                    break;
                case 8:
                    uf = "SP";
                    break;
                case 9:
                    uf = "PR, SC";
                    break;
            }

            return uf;
        }
    }
}