using System;

namespace AventuraChanante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para que se vean bien las tildes y los signos ¿ ¡ en la consola de Windows
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== LA VERDADERA HISTORIA DE LA MONA CHITA ===");
            Console.WriteLine("(Elige escribiendo el número de la opción y pulsando Enter)");
            Console.WriteLine();

            Presentacion();

            Console.WriteLine();
            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey();
        }

        // ---------- ESCENA 1: PRESENTACIÓN ----------
        static void Presentacion()
        {
            Console.WriteLine("Jiggs se coloca delante de la cámara y se rasca la cabeza.");
            Console.WriteLine("A ver, ¿cómo empezaba esto?... Ah, sí. Hola, soy la mona Chita.");
            Console.WriteLine("Bueno, en realidad no. Soy Jiggs, el chimpancé que hacía de Chita en las películas de Tarzán.");
            Console.WriteLine("Conocidísimo por mi estelar actuación en la celebérrima película de Tarzán y su amigo el cocodrilo. Y por mis gritos, claro.");
            Console.WriteLine();
            Console.WriteLine("1. Cuéntame lo de Tarzán");
            Console.WriteLine("2. ¿Qué es eso que dices siempre del color?");
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                Cocodrilo();
            }
            else if (opcion == "2")
            {
                Color();
            }
            else
            {
                FinGenDeMono();
            }
        }

        // ---------- ESCENA 2: EL COCODRILO ----------
        static void Cocodrilo()
        {
            Console.WriteLine("Una vez Tarzán estaba en el río y apareció un cocodrilo enorme.");
            Console.WriteLine("Y yo, sin pensarlo, cogí un palo y se lo metí en la boca al bicho. Le salvé la vida.");
            Console.WriteLine("Tarzán, el de los gritos, sí. Pues el que le salvaba era yo.");
            Console.WriteLine();
            Console.WriteLine("El otro día estaba viendo esa película con mi cuidador, tan a gusto, y va y me suelta:");
            Console.WriteLine("Qué pena que sea en blanco y negro, ¿verdad, Jiggs?");
            Console.WriteLine();
            Console.WriteLine("¿Qué le contesta Jiggs al cuidador?");
            Console.WriteLine("1. Darle la razón y seguir viendo la película");
            Console.WriteLine("2. Mosquearse con el cuidador");
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                Console.WriteLine("Sí, sí, una pena, le dije. Aunque yo no sabía muy bien de qué me estaba hablando.");
                Console.WriteLine("Al acabar la película, el cuidador se levantó y me trajo un paquete.");
                Console.WriteLine();
                Paquete();
            }
            else if (opcion == "2")
            {
                Console.WriteLine("¿Cómo que qué pena? ¿Qué le pasa al blanco y negro? ¡Que es mi película!");
                Console.WriteLine();
                Color();
            }
            else
            {
                FinGenDeMono();
            }
        }

        // ---------- ESCENA 3: EL COLOR ----------
        static void Color()
        {
            Console.WriteLine("¿Color? ¿Qué es el color? ¿Te refieres a los grises? ¿Al gris claro y al gris oscuro?");
            Console.WriteLine();
            Console.WriteLine("1. Explicarle que existen los colores: rojo, verde, azul...");
            Console.WriteLine("2. Darle la razón: todo es gris");
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                Console.WriteLine("¿Rojo? ¿Verde? ¿Me estás tomando el pelo?");
                Console.WriteLine("¡URRRGG! ¡ARRRGG! ¡URRRGGG ARRRGGG!");
                Console.WriteLine("Jiggs tira todo lo que tiene a mano. Y de repente, se le pasa y grita: ¡Monkeyyyys!");
                Console.WriteLine("Pero tú ya estás en la calle, corriendo.");
                Console.WriteLine();
                Console.WriteLine("*** FIN: El arrebato ***");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("¡Eso! Por fin alguien con criterio. Me has puesto contento. ¡Monkeyyyys!");
                Console.WriteLine("Cuando estoy contento soy un trozo de pan, ¿eh? Por ejemplo, el otro día...");
                Console.WriteLine();
                Sobrino();
            }
            else
            {
                FinGenDeMono();
            }
        }

        // ---------- ESCENA 4: EL SOBRINO DEL CUIDADOR ----------
        static void Sobrino()
        {
            Console.WriteLine("Estaba yo tan tranquilo, jugando con un palo, tirándolo y recogiéndolo, que es lo que más nos gusta a los monos.");
            Console.WriteLine("Eso y despiojarnos, que es como las pipas: empiezas y no acabas.");
            Console.WriteLine("Y llega el sobrino de mi cuidador: ¡Tío, tío! ¿Puedo acariciarlo?");
            Console.WriteLine("Y el cuidador: Claro que sí, si no hace nada.");
            Console.WriteLine("Yo estaba de espaldas, con la oreja puesta, haciéndome el despistado...");
            Console.WriteLine();
            Console.WriteLine("¿Qué hace Jiggs?");
            Console.WriteLine("1. Ser un mono bueno y dejarse acariciar");
            Console.WriteLine("2. Darse la vuelta y pegarle un mordisco");
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                Console.WriteLine("Me quedé quietecito y me dejé. Ay, qué pelo más suave, decía el niño. Y yo, encantado, oye.");
                Console.WriteLine("Con tanto mimo me entró la inspiración. Ven, que te enseño lo que estoy pintando.");
                Console.WriteLine();
                Pintura();
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Me giré de golpe y... ¡ÑAAAM! Le arranqué dos dedos de cuajo.");
                Console.WriteLine("Ahora me río, pero en el momento, menuda movida. Madre mía.");
                Console.WriteLine("El niño gritando, el cuidador gritando, yo con los dedos en la boca sin saber qué hacer con ellos...");
                Console.WriteLine("Tranquilos, ¿eh? Que como fue un corte limpio, luego se los volvieron a poner.");
                Console.WriteLine("Eso sí, a mí me dejaron un mes sin plátanos. Y al niño no le he vuelto a ver por aquí.");
                Console.WriteLine();
                Console.WriteLine("*** FIN: Menuda movida ***");
            }
            else
            {
                FinGenDeMono();
            }
        }

        // ---------- ESCENA 5: LA EDICIÓN DE LUJO ----------
        static void Paquete()
        {
            Console.WriteLine("¡Ah, esto! Me ha llegado la edición de lujo de las películas de Tarzán. Después de sesenta años, se han dado prisa.");
            Console.WriteLine("Y trae un libreto con fotos. Seguro que salgo yo en muchas, ¿eh?");
            Console.WriteLine("Jiggs pasa páginas. Tarzán. Jane. Tarzán otra vez. Un cocodrilo. De Jiggs, ni rastro.");
            Console.WriteLine("No pasa nada, ¿eh? No me afecta. Estoy tranquilo. (Le tiembla un ojo.)");
            Console.WriteLine();
            Console.WriteLine("1. Seguro que sales en las últimas páginas");
            Console.WriteLine("2. ¿Y si pintamos algo para relajarnos?");
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                Console.WriteLine("Llega a la última página. Sale el cocodrilo. Otra vez.");
                Console.WriteLine("¿¡El cocodrilo tiene más fotos que yo!? ¡URRRGGG!");
                Console.WriteLine("La edición de lujo ya no es de lujo. Ahora es confeti.");
                Console.WriteLine();
                Console.WriteLine("*** FIN: Edición destrozada ***");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Pintar... Sí. Pintar me calma. Es mi otra gran pasión, además de cabrearme.");
                Console.WriteLine();
                Pintura();
            }
            else
            {
                FinGenDeMono();
            }
        }

        // ---------- ESCENA 6: LA PINTURA ----------
        static void Pintura()
        {
            Console.WriteLine("Jiggs se aparta del caballete, muy serio.");
            Console.WriteLine("Mira lo que estoy pintando. Es el cielo de noche. Con una estrella.");
            Console.WriteLine();
            Console.WriteLine("   +----------------------------+");
            Console.WriteLine("   |                            |");
            Console.WriteLine("   |                            |");
            Console.WriteLine("   |              ·             |");
            Console.WriteLine("   |                            |");
            Console.WriteLine("   |                            |");
            Console.WriteLine("   +----------------------------+");
            Console.WriteLine();
            Console.WriteLine("¿Qué? ¿Lo dejo así o le doy otro meneo?");
            Console.WriteLine("1. Déjalo así, está bien");
            Console.WriteLine("2. Dale unas pinceladas más, que le falta un poco de gris");
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                Console.WriteLine("Jiggs mira el cuadro, mira al techo y asiente despacio.");
                Console.WriteLine("Pues sí.He contado hasta dos antes de estroperlo. Ríete tú de Barceló.");
                Console.WriteLine();
                Firma();
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Jiggs se queda quieto. Muy quieto. Demasiado quieto.");
                Console.WriteLine("Ves, mal, porque te habré hecho caso, si hubiese contado hasta dos");
                Console.WriteLine("¡¡MAAAAAL!! ¡¡MAAAL!! ¡¡URRRGGG, MAAAL, ARRRGGG!!");
                Console.WriteLine("El caballete sale volando por la ventana. El pincel, también. Tú, casi.");
                Console.WriteLine();
                Console.WriteLine("*** FIN: Arrebato artístico ***");
            }
            else
            {
                FinGenDeMono();
            }
        }

        // ---------- ESCENA 7: LA FIRMA ----------
        static void Firma()
        {
            Console.WriteLine("¿Queréis ver cómo firmo? Mira.");
            Console.WriteLine("Jiggs moja el dedo en la pintura y deja una huella enorme en la esquina.");
            Console.WriteLine("Firmado. Te lo regalo. Aún me da tiempo a pintar otro antes de almorzar.");
            Console.WriteLine();
            Console.WriteLine("1. Aceptar el cuadro, muy agradecido");
            Console.WriteLine("2. Decirle que, puestos a pedir, le falta un poco de azul");
            string? opcion = Console.ReadLine();
            Console.WriteLine();

            if (opcion == "1")
            {
                Console.WriteLine("Te llevas el cuadro a casa y lo cuelgas en el salón. Las visitas no entienden nada.");
                Console.WriteLine("Tú sí: es una obra única, firmada por el mismísimo Jiggs.");
                Console.WriteLine();
                Console.WriteLine("*** FIN: El artista ***");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("¿Azul? ¿Qué es azul? ¿Otro gris?");
                Console.WriteLine("Una parte de su cerebro de mono le dice que no lo toque. La otra, que le dé un viaje.");
                Console.WriteLine("Jiggs intenta contar hasta dos para calmarse... uno... dos... No llega al tres. El cuadro tampoco.");
                Console.WriteLine();
                Console.WriteLine("*** FIN: Cuenta hasta dos ***");
            }
            else
            {
                FinGenDeMono();
            }
        }

        // ---------- FINAL PARA RESPUESTAS NO VÁLIDAS ----------
        static void FinGenDeMono()
        {
            Console.WriteLine("¡Urgg, urgg, arrgggg! Perdona, es que me sale el gen de mono cuando no contestas bien.");
            Console.WriteLine();
            Console.WriteLine("*** FIN: El gen de mono ***");
        }
    }
}