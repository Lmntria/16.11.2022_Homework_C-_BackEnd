using System;
using System.Collections.Generic;

namespace Second_Task.Models
{
	public static class Data
	{
        public static List<Service> Services = new List<Service>
        {
            new Service{id="1",heading="Lorem Ipsom",info="lorem10"},
            new Service{id="2",heading="Lorem Ipsom",info="lorem10"},
            new Service{id="3",heading="Lorem Ipsom",info="lorem10"},
            new Service{id="4",heading="Lorem Ipsom",info="lorem10"},
            new Service{id="5",heading="Lorem Ipsom",info="lorem10"},
            new Service{id="6",heading="Lorem Ipsom",info="lorem10"},
        };

        public static List<Features> Features = new List<Features>
        {
            new Features{id="1",head="Lorem Ipsom",info="Lorem8",},
            new Features{id="2",head="Lorem Ipsom",info="Lorem8",},
            new Features{id="3",head="Lorem Ipsom",info="Lorem8",}
        };

	}
}

