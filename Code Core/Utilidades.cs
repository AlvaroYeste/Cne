using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conozca_a_su_nuevo_empleado
{
    public class Utilidades : Random
    {
        public static Tuple<string, string> FraseAleatoria()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 16);
            string frase = "", imagen = "";
            switch(a)
            {
                case 1:
                    frase = "Pícaro, jugador, gato, programador, pirata, coleccionista de personalidades, tramposo, músico reprimido, bromista, abogado del diablo, leal, despreocupado, como una cabra...Álvaro Yeste. (1/15)";
                    imagen = "guapo";
                    break;
                case 2:
                    frase = "Experiencia: dícese del arte de olvidar las razones por las cuales realizas una serie de pasos, normas o estándares a la hora de realizar cualquier tarea, ya que de otra forma, sabes que algo saldrá mal (2/15)";
                    imagen = "lectura";
                    break;
                case 3:
                    frase = "Chicas, si queréis saber si un chico os quiere de verdad, id a cenar con él. Si os invita a cualquier cosa y os permite robarle comida, casaos con él, os ama por encima de la comida y eso es amor de verdad. (3/15)";
                    imagen = "confiado";
                    break;
                case 4:
                    frase = "Chicas, si queréis saber si un chico os quiere de verdad, habladle mientras juega videojuegos. Si pone la pausa para escucharte, aunque sea un juego online, casaos con él, os ama por encima de los videojuegos y eso es amor de verdad. (4/15)";
                    imagen = "confiado";
                    break;
                case 5:
                    frase = "¿No sería jodidamente irónico que tu abuelo te llame drogadicto de mierda mientras se traga sus pastillas para el corazón? (5/15)";
                    imagen = "ironico";
                    break;
                case 6:
                    frase = "Existen solo dos tipos de problemas, los que te surgen y los que te buscas, y cada uno sabrá de cuales tiene más. (6/15)";
                    imagen = "dos";
                    break;
                case 7:
                    frase = "La comida es al estómago, lo que la música es para el corazón. (7/15)";
                    imagen = "budista";
                    break;
                case 8:
                    frase = "Entiendo a los niños mejor que a muchas personas... (8/15)";
                    imagen = "meh";
                    break;
                case 9:
                    frase = "Hardware: A lo que le pegas." + System.Environment.NewLine + "Software: La razón por la que le pegas. (9/15)";
                    imagen = "dos";
                    break;
                case 10:
                    frase = "La felicidad eterna no existe, tarde o temprano volverás a tener hambre. (10/15)";
                    imagen = "budista";
                    break;
                case 11:
                    frase = "La próxima vez que os paren por exceso de velocidad, tratad de parecer lo más perturbados posible, cuando os pregunten qué os pasa gritad con la voz lo más quebrada posible ¡¡¡QUE ME ESTOY CAGANDO COÑO!!! (11/15)";
                    imagen = "yao_ming";
                    break;
                case 12:
                    frase = "Muy raro tiene que ser un problema para que un sudamericano no haya subido un tutorial a YouTube. (12/15)";
                    imagen = "perturbado";
                    break;
                case 13:
                    frase = "¿Preocupación? ¡Tú no sabes lo que es la preocupación! Preocupación es ver a un compañero pedir una hoja extra en pleno examen, terror, es ver a 3 compañeros pedir una hoja extra en el examen, pánico es ver al primero pedir otra más. (13/15)";
                    imagen = "perturbado";
                    break;
                case 14:
                    frase = "Solo en ese momento en que un mosquito se te para en la entrepierna se te revela que no todo se soluciona con violencia. (14/15)";
                    imagen = "budista";
                    break;
                case 15:
                    frase = "La gente dice que el amor es el mejor sentimiento que puedes sentir. Pero yo creo que encontrar un baño cuando se tiene diarrea es mucho mejor, solo superado por el que sentiste cuando te comiste todo eso. (15/15)";
                    imagen = "yao_ming";
                    break;
                default:
                    break;
            }
            return Tuple.Create(frase, imagen);
        }
        public static string TextoAleatorio()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 6);
            string texto = "";
            switch(a)
            {
                case 1:
                    texto = "¡Ey! ¿Jugamos?";
                    break;
                case 2:
                    texto = "¿Quieres jugar a un juego?";
                    break;
                case 3:
                    texto = "¿Juegas?";
                    break;
                case 4:
                    texto = "¿Cansado? ¡Juega!";
                    break;
                case 5:
                    texto = "¿Una partida?";
                    break;
            }
            return texto;
        }
        public static int[] Desordenar(int[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                int k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
        }
    }
}
