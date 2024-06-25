using System;
using System.Reflection;

namespace LSG.Infrastructure.Framework.BaseClasses.MessageTransfert
{

        public enum AcknowledgeType
        {
            Failure = 0,
            Success = 1,
            Warning = 2
        }

        public abstract class MessageResponseBase
        {
            AcknowledgeType _acknowledgeType = AcknowledgeType.Success;

            /// <summary>
            /// Un flag che indica al client il successo o il fallimento del web service. 
            /// Il default è successo.       
            /// </summary>
            public AcknowledgeType Acknowledge
            {
                get { return _acknowledgeType; }
                set { _acknowledgeType = value; }
            }

            /// <summary>
            /// E' l'Id dell' istanza di Request ritornato al client
            /// </summary>

            public string RequestId { get; set; }

            /// <summary>
            /// E' un messaggio tornato al client.
            /// Usato principalmente in caso di errore
            /// </summary>
            public string Message { get; set; }

            /// <summary>
            /// E' un id di prenotazione per tenere traccia delle request 
            /// che richiedono lunghi tempi di elaborazione.
            /// Può essere utilizzato in seconda istanza per verificare lo stato di un elaborazione.
            /// </summary>
            public string ReservationId { get; set; }

            /// <summary>
            /// E' la data fine della prenotazione
            /// </summary>
            public DateTime ReservationExpires { get; set; }

            /// <summary>
            /// Riporta al client il numero di versione del webservice eseguito.
            ///     
            /// </summary>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
            public string Version
            {
                get
                {
                    return Assembly.GetExecutingAssembly().GetName().Version.Major + "." +
                        Assembly.GetExecutingAssembly().GetName().Version.Minor;
                }
            }

            /// <summary>
            /// Riporta al client il numero di build del webservice eseguito.
            ///     
            /// </summary>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
            public string Build
            {
                get
                {
                    return Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();
                }
            }


        }
}





