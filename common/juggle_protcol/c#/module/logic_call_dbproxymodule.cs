/*this module file is codegen by juggle for c#*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace module
{
    public class logic_call_dbproxy : juggle.Imodule 
    {
        public logic_call_dbproxy()
        {
			module_name = "logic_call_dbproxy";
        }

        public delegate void reg_logichandle(String argv0);
        public event reg_logichandle onreg_logic;
        public void reg_logic(ArrayList _event)
        {
            if(onreg_logic != null)
            {
                var argv0 = ((String)_event[0]);
                onreg_logic( argv0);
            }
        }

        public delegate void create_persisted_objecthandle(String argv0, Int64 argv1);
        public event create_persisted_objecthandle oncreate_persisted_object;
        public void create_persisted_object(ArrayList _event)
        {
            if(oncreate_persisted_object != null)
            {
                var argv0 = ((String)_event[0]);
                var argv1 = ((Int64)_event[1]);
                oncreate_persisted_object( argv0,  argv1);
            }
        }

        public delegate void updata_persisted_objecthandle(String argv0, String argv1, Int64 argv2);
        public event updata_persisted_objecthandle onupdata_persisted_object;
        public void updata_persisted_object(ArrayList _event)
        {
            if(onupdata_persisted_object != null)
            {
                var argv0 = ((String)_event[0]);
                var argv1 = ((String)_event[1]);
                var argv2 = ((Int64)_event[2]);
                onupdata_persisted_object( argv0,  argv1,  argv2);
            }
        }

        public delegate void get_object_infohandle(String argv0, Int64 argv1);
        public event get_object_infohandle onget_object_info;
        public void get_object_info(ArrayList _event)
        {
            if(onget_object_info != null)
            {
                var argv0 = ((String)_event[0]);
                var argv1 = ((Int64)_event[1]);
                onget_object_info( argv0,  argv1);
            }
        }

        public delegate void logic_closedhandle();
        public event logic_closedhandle onlogic_closed;
        public void logic_closed(ArrayList _event)
        {
            if(onlogic_closed != null)
            {
                onlogic_closed();
            }
        }

	}
}
