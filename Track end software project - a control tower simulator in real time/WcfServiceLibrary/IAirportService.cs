﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    [ServiceContract(CallbackContract = typeof(IAirportServiceCallBack))]  //DB CRUD USER
    
    public interface IAirportService
    {
   
    }

    public interface IAirportServiceCallBack 
    {
    }
}
