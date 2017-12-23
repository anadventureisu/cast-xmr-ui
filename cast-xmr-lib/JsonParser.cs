using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastXmrLib
{
    /// <summary>
    /// Parses JSON data from the web service
    /// 
    /// 
    /// 
    /// </summary>
    public class JsonParser
    {

        // Sample:
        //  {
        //	"total_hash_rate": 1857957,
        //	"total_hash_rate_avg": 1812193,
        //	"pool": {
        //		"server": "pool.supportxmr.com:7777",
        //		"status": "connected",
        //		"online": 15,
        //		"offline": 0,
        //		"reconnects": 0,
        //		"time_connected": "2017-12-13 16:23:40",
        //		"time_disconnected": "2017-12-13 16:23:40"
        //	},
        //	"job": {
        //		"job_number": 3,
        //		"difficulty": 25000,
        //		"running": 11,
        //		"job_time_avg": 1.50
        //	},
        //	"shares": {
        //		"num_accepted": 2,
        //		"num_rejected": 0,
        //		"num_invalid": 0,
        //		"num_network_fail": 0,
        //		"num_outdated": 0,
        //		"search_time_avg": 5.00
        //	},
        //	"devices": [
        //	{
        //		"device": "GPU0",
        //		"device_id": 0,
        //		"hash_rate": 1857957,
        //		"hash_rate_avg": 1812193,
        //		"gpu_temperature": 41,
        //		"gpu_fan_rpm": 3690

        //    }
        //	]
        //}

        public static void Parse(string json, AppState state)
        {
            JObject data = JObject.Parse(json);

            // Update shares
            state.SharesAccepted = (int)data["shares"]["num_accepted"];
            state.SharesRejected = (int)data["shares"]["num_rejected"];
            state.SharesInvalid = (int)data["shares"]["num_invalid"];
            state.SharesOutdated = (int)data["shares"]["num_outdated"];
            state.SharesNetworkError = (int)data["shares"]["num_network_fail"];
            state.TotalShares = state.SharesAccepted + state.SharesInvalid + state.SharesNetworkError + state.SharesOutdated + state.SharesRejected;
            

            // Update devices.
            foreach (JToken device in data["devices"])
            {
                int index = (int)device["device_id"];
                GpuSample sample = new GpuSample(DateTime.Now, (long)device["hash_rate"]/1000, (int)device["gpu_fan_rpm"], (int)device["gpu_temperature"]);
                GpuState gpu = state.GetGpu(index);
                gpu.AddSample(sample);
                gpu.UpdateAverages();
                gpu.PruneSamplesOlderThan(TimeSpan.FromHours(1));
            }
            state.UpdateGlobalRates();

        }

    }
}
