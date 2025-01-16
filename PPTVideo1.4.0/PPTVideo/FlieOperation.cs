using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTVideo
{
    class FileOperation
    {
        //读取json文件
        public JObject ReadJsonData(string jsonFile)
        {
            byte[] jsonBytes = File.ReadAllBytes(jsonFile);
            string jsonContent = Encoding.UTF8.GetString(jsonBytes);
            JObject jsonObject = JObject.Parse(jsonContent);
            return jsonObject;
        }


        //对文件进行base64编码
        public string EncodeBase64(string path)
        {
            byte[] Bytes = File.ReadAllBytes(path);
            string data_base64 = Convert.ToBase64String(Bytes);
            return data_base64;
        }

        //对字典进行保存
        public void DictDataSave(Dictionary<string, string> dictData, string saveFile)
        {
            // 将字典序列化为JSON字符串
            string jsonString = JsonConvert.SerializeObject(dictData, Formatting.Indented);
            // 将JSON字符串保存到文件
            File.WriteAllText(saveFile, jsonString);
        }

    }
}
