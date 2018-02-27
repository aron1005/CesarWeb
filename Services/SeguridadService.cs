namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        // para que no pase y brinque numeros
        static string ABECEDARIO = ("'A'BCDEFGHIJKLMNÑOPQRSTUVWXYZABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string abecedario= ("'z'yxwvutsrqpoñnmlkjihgfedcbazyxwvutsrqpoñnmlkjihgfedcba");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            int a=0;
            int t=0;
            string igualar=Mensaje;
            for(a=0;a<Mensaje.Length;a++){
                for(t=0;t<=52;t++){
                    //  mayusculas
                    if(Mensaje[a]==ABECEDARIO[t]){
                        igualar=igualar.Replace(igualar[a],ABECEDARIO[t-clave]);
                    }
                    // minusculas
                    if(Mensaje[a]==abecedario[t]){
                        igualar=igualar.Replace(igualar[a],abecedario[t-clave]);
                    }
                }
            }
            Mensaje=igualar;
            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
    {
            int aron=0;
            int tory=0;
            string comparacion=Mensaje;
            for(aron=0;aron<Mensaje.Length;aron++){
                for(tory=0;tory<=52;tory++){
                    if(Mensaje[aron]==ABECEDARIO[tory]){

                        comparacion=comparacion.Replace(comparacion[aron],ABECEDARIO[tory+clave]);
                    }
                    if(Mensaje[aron]==abecedario[tory]){
                        comparacion=comparacion.Replace(comparacion[aron],abecedario[tory-clave]);
                    }
                }
            }
            Mensaje=comparacion;
            return Mensaje;
        }
    }
}