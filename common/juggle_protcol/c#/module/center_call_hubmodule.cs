/*this module file is codegen by juggle for c#*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace module
{
    public class center_call_hub : juggle.Imodule 
    {
        public center_call_hub()
        {
			module_name = "center_call_hub";
        }

        public delegate void distribute_dbproxy_addresshandle(String argv0, String argv1, Int64 argv2, String argv3);
        public event distribute_dbproxy_addresshandle ondistribute_dbproxy_address;
        public void distribute_dbproxy_address(ArrayList _event)
        {
            if(ondistribute_dbproxy_address != null)
            {
                var argv0 = ((String)_event[0]);
                var argv1 = ((String)_event[1]);
                var argv2 = ((Int64)_event[2]);
                var argv3 = ((String)_event[3]);
                ondistribute_dbproxy_address( argv0,  argv1,  argv2,  argv3);
            }
        }

	}
}
