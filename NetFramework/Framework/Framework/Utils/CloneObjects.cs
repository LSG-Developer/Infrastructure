using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace  LSG.Framework.Factory.Infrastructure.Framework.Utils
{
        
    ///<Author>Luigi  Infrastructure</Author>
    /// <CreationDate>11/06/2007</CreationDate>
    /// <AuthorModifier>Luigi  Infrastructure</AuthorModifier>
    /// <DateModify>11/06/2007</DateModify>
    /// <summary>
    /// 
    /// </summary>	
   //public class CloneObjects
   //{
   //    ///<Author>Luigi  Infrastructure</Author>
   //    /// <CreationDate>11/06/2007</CreationDate>
   //    /// <AuthorModifier>Luigi  Infrastructure</AuthorModifier>
   //    /// <DateModify>11/06/2007</DateModify>
   //    /// <summary>
   //    /// 
   //    /// </summary>
   //    /// <exception cref="System.InvalidOperationException">occurred when object to clone is not serializable</exception>		
   //    public static T CloneObject<T>(T objectToClone) 
   //    {
   //            T genericCloneObject= default(T);
   //            Type type = typeof(T);
   //            bool serializable = type.IsSerializable;
   //            if (serializable == false)
   //            {
   //                string message = "The type " + type + " is not serializable";
   //                throw new System.InvalidOperationException(message);
   //            }
   //            MemoryStream ms = new MemoryStream();
   //            BinaryFormatter buffer = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
   //            // Serializza l’oggetto nello stream.
   //            buffer.Serialize(ms, objectToClone);
   //            ms.Seek(0, SeekOrigin.Begin);
   //            // Lo deserializza in un oggetto differente e rilascia la memoria.
   //             genericCloneObject = (T)buffer.Deserialize(ms);
   //            //ms.Close();
   //            return genericCloneObject;
   //    }
   //}
    
    
}
