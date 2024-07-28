using System.Xml.Serialization;

namespace LSG.Framework.Factory.Infrastructure.Framework.BaseClasses.MessageTransfert
{
        /// <summary>
        /// Classe base pe tutte le request ai web service di Vittoria Assicurazioni.
        /// </summary>
        public abstract class MessageRequestBase
        {
            /// <summary>
            /// Token necessario per implementare la sicurezza nel momento in cui il client
            /// non potesse usare le NetworkCredential
            /// </summary>
            public string? SecurityToken { get; set; }
            /// <summary>
            /// E' il numero di versione del servizio richiesto.
            /// Necessario a garantire la compatibilità indietro 
            /// potrebbe non essere necessario con l'adozione di MSE
            /// </summary>
            public string? Version { get; set; }
            /// <summary>
            /// E' uno unique id (idealmente un guid) fornito dal client per identificare
            /// una singola istanza della richiesta. 
            /// E' indispensabile quando si vuole garantire l'idempotenza di un metodo 
            /// per evitare che la stessa chiamata (erroneamente ripetuta) venga elaborata più volte
            /// </summary>
            [XmlElement(IsNullable = false)]
            public string? RequestId { get; set; }
            /// <summary>
            /// Ambiente
            /// </summary>
            public string? StageName { get; set; }

        }
    }
