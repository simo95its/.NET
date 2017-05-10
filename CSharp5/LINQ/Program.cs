using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data
            List<Ordine> ordini = new List<Ordine>()
            {
                
                new Ordine
                {
                    Id = 1,
                    Data = DateTime.Now,
                    Dettagli = new List<DettaglioOrdine>()
                    {
                        new DettaglioOrdine
                        {
                            Id = 1,
                            Prezzo = 50,
                            Quantita = 10
                        },
                        new DettaglioOrdine
                        {
                            Id = 2,
                            Prezzo = 30,
                            Quantita = 1
                        },
                        new DettaglioOrdine
                        {
                            Id = 3,
                            Prezzo = 12,
                            Quantita = 13
                        }
                    }.ToArray()
                },
                new Ordine
                {
                    Id = 2,
                    Data = DateTime.Now.AddDays(-10),
                    Dettagli = new List<DettaglioOrdine>()
                    {
                        new DettaglioOrdine
                        {
                            Id = 4,
                            Prezzo = 32,
                            Quantita = 18
                        },
                        new DettaglioOrdine
                        {
                            Id = 5,
                            Prezzo = 15,
                            Quantita = 4
                        }
                    }.ToArray()
                },
                new Ordine
                {
                    Id = 3,
                    Data = DateTime.Now.AddDays(-5),
                    Dettagli = new List<DettaglioOrdine>()
                    {
                        new DettaglioOrdine
                        {
                            Id = 6,
                            Prezzo = 2,
                            Quantita = 9
                        },
                        new DettaglioOrdine
                        {
                            Id = 7,
                            Prezzo = 15,
                            Quantita = 4
                        },
                        new DettaglioOrdine
                        {
                            Id = 8,
                            Prezzo = 21,
                            Quantita = 150
                        },
                        new DettaglioOrdine
                        {
                            Id = 9,
                            Prezzo = 1,
                            Quantita = 400
                        },
                        new DettaglioOrdine
                        {
                            Id = 10,
                            Prezzo = 3,
                            Quantita = 84
                        }
                    }.ToArray()
                },
                new OrdineEx
                {
                    Id = 4,
                    IsInternational = true,
                    Data = DateTime.Now.AddDays(-5),
                    Dettagli = new List<DettaglioOrdine>()
                    {
                        new DettaglioOrdine
                        {
                            Id = 11,
                            Prezzo = 2,
                            Quantita = 30
                        },
                        new DettaglioOrdine
                        {
                            Id = 12,
                            Prezzo = 2,
                            Quantita = 2
                        }
                    }.ToArray()
                }
            };
            #endregion

            #region Example
            var o = ordini
                .Where(w => w.Id == 1)
                .Select(s => new { s.Data, s.Id });

            Console.WriteLine("Example");
            foreach (var i in o)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion

            #region OperatoriDiRestrizione
            #region Where
            Console.WriteLine("Where");
            var result = ordini
                .Where(w => w.Id == 1 && w.Data.Date == DateTime.Now.Date);
            
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            result = null;
            result = ordini.Where(w => w.Id == 1);
            result = ordini.Where(w => w.Data.Date == DateTime.Now.Date);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            result = null;
            result = ordini.Where((w, i) => i % 2 == 0); //indice array 0-n

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion

            #region OfType
            Console.WriteLine("OfType");
            //torna tutti gli oggetti OrdineEx isA Ordine
            var res1 = ordini.OfType<Ordine>();
            //torna solo OrdineEx
            var res2 = ordini.OfType<OrdineEx>();

            foreach (var i in res1)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            foreach (var i in res2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion
            #endregion

            #region OperatoriDiProiezione
            #region Select
            Console.WriteLine("Select");

            var res = ordini.Select(s => s.Id);

            foreach (var i in res)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            var res3 = ordini.Select(s => new OrdineDTO { Id = s.Id, Data = s.Data });

            foreach (var i in res3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            var res4 = ordini.Select(s => new { s.Id, s.Data });

            foreach (var i in res4)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            var res5 = ordini.Select(s => new { IdOrdine = s.Id, DataOrdine = s.Data });

            foreach (var i in res5)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion

            #region SelectMany
            Console.WriteLine("SelectMany");

            var res6 = ordini
                .Where(w => w.Id == 1)
                .Select(s => s.Dettagli);

            foreach(var i in res6)
            {
                for(int j = 0; j < i.Length; j++)
                {
                    Console.WriteLine(i[j]);
                }
            }
            Console.ReadLine();

            var res7 = ordini.SelectMany(sm => sm.Dettagli);

            foreach (var i in res7)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion
            #endregion

            #region OperatoriDiOrdinamento
            #region 
            #endregion
            #endregion
        }

        
    }
}
