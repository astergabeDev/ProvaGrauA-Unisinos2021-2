namespace ProvaGA
{
    public class Data
    {
        string data;

        public Data(string dataC)
        {
            if(validarData(dataC))
            {
                this.data = dataC;
            }else 
            {
                this.data = "01/01/0001";
            }
            
        }
        private bool validarData(string data)
        {
            int dia = int.Parse(data.Split("/")[0]);
            int mes = int.Parse(data.Split("/")[1]);
            int ano = int.Parse(data.Split("/")[2]);

            if(dia > 0 && dia < 32 && mes > 0 && mes < 13 && (mes == 2 && dia < 30) && ano > 0)
            {
                return true;
            }
            return false;
        }
        public int compara(Data dataCompara)
        {
            if (dataCompara.getAno() > getAno())
            {
                return -1;
            }
            if (dataCompara.getAno() == getAno())
            {
                if (dataCompara.getMes() > getMes())
                {
                    return -1;
                }
                if (dataCompara.getMes() == getMes())
                {
                    if (dataCompara.getDia() > getDia())
                    {
                        return -1;
                    }
                    if (dataCompara.getDia() == getDia())
                    {
                        return 0;
                    }
                    return 1;
                }
                return 1;
            }
            return 1;

        }
        public int getDia()
        {
            return int.Parse(data.Split("/")[0]);
        }
        public int getMes()
        {
            return int.Parse(data.Split("/")[1]);
        }
        public string getMesExtenso()
        {
            int mes = getMes();
            switch (mes)
            {
                case 1:
                    return "Janeiro";
                case 2:
                    return "Fevereiro";
                case 3:
                    return "Março";
                case 4:
                    return "Abril";
                case 5:
                    return "Maio";
                case 6:
                    return "Junho";
                case 7:
                    return "Julho";
                case 8:
                    return "Agosto";
                case 9:
                    return "Setembro";
                case 10:
                    return "Outubro";
                case 11:
                    return "Novembro";
                case 12:
                    return "Dezembro";                    
                default:
                    return "";
            }
        }
        public int getAno()
        {
            return int.Parse(data.Split("/")[2]);
        }
        public bool isBissexto()
        {
            return getDia() == 29 && getMes() == 2;
        }
    }
}