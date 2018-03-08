

using System.Text;

namespace VigenereWeb.Services
{

    public class VigenereSeguridadService : ISeguridadService<string>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");

        ///  Aquí deben hacer la parte del código necesario para Desencriptar el mensaje

        public string DesEncriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
             StringBuilder msjEncriptado = new StringBuilder();
           int claxson=0;
                int y=0;
                  clave=clave.ToUpper();
            foreach (var letra in Mensaje)
            {
                
              
                if (char.IsLetter(letra))
                {
                   if(y>=clave.Length){
                       y=0;
                   }
                   for(int i=0;i<ABECEDARIO.Length;i++){
                       if(clave[y]==ABECEDARIO[i]){
                           claxson=i;
                       }
                   }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraEnc = (posLetra - claxson) % ABECEDARIO.Length;
                    var letrEnc = ABECEDARIO[posLetraEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letrEnc);
                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letrEnc));
                    }
                    y++;
                    }


                
                else
                {
                    msjEncriptado.Append(letra);
                }}
            
            return msjEncriptado.ToString();
             


        }



        //  Aquí deben hacer la parte del código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, string clave)
        {
            /// sirve para construir una cadena de manera dinamica
           StringBuilder msjEncriptado = new StringBuilder();
           int claxson=0;
                int y=0;
                  clave=clave.ToUpper();
            foreach (var letra in Mensaje)
            {
                
              
                if (char.IsLetter(letra))
                {
                   if(y>=clave.Length){
                       y=0;
                   }
                   for(int i=0;i<ABECEDARIO.Length;i++){
                       if(clave[y]==ABECEDARIO[i]){
                           claxson=i;
                       }
                   }
                    var posLetra = ABECEDARIO.IndexOf(char.ToUpper(letra));
                    var posLetraEnc = (posLetra + claxson) % ABECEDARIO.Length;
                    var letrEnc = ABECEDARIO[posLetraEnc];
                    if (char.IsUpper(letra))
                    {
                        msjEncriptado.Append(letrEnc);
                    }
                    else
                    {
                        msjEncriptado.Append(char.ToLower(letrEnc));
                    }
                    y++;
                    }


                
                else
                {
                    msjEncriptado.Append(letra);
                }}
            
            return msjEncriptado.ToString();
        }
    }


}