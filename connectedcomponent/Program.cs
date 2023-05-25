using connectedcomponent;

var ribrs=new List<Ribr>();
string peakstr="";
StreamReader streamReader=new StreamReader("1.txt");
Console.WriteLine("Введите ребра");
while(true){
    string str=streamReader.ReadLine();
    if (str==null) break;
    var ribr=new Ribr();
    ribr.peak1=Convert.ToString(str.Split(" ")[0]);
    if (!peakstr.Contains(ribr.peak1)){
        peakstr+=ribr.peak1;
    } 
    ribr.peak2=Convert.ToString(str.Split(" ")[1]);
    if (!peakstr.Contains(ribr.peak2)){
        peakstr+=ribr.peak2;
    }
    ribrs.Add(ribr); 
}
streamReader.Close();
var components=new List<string>();
components.Add(ribrs[0].peak1);
peakstr=peakstr.Replace(ribrs[0].peak1,"");
while (peakstr.Length!=0){
    foreach(var ribr in ribrs){
        bool check=false;
        for(int i=0;i<components.Count();i++){
            if (components[i].Contains(ribr.peak1)||components[i].Contains(ribr.peak2)){
                if (components[i].Contains(ribr.peak1)&&components[i].Contains(ribr.peak2)){
                    check=true;
                    break;
                }
                if (!components[i].Contains(ribr.peak1)&&components[i].Contains(ribr.peak2)){
                    components[i]+=ribr.peak1;
                    check=true;
                    peakstr=peakstr.Replace(ribr.peak1,"");
                    break;
                }
                if (components[i].Contains(ribr.peak1)&&!components[i].Contains(ribr.peak2)){
                    components[i]+=ribr.peak2;
                    check=true;
                    peakstr=peakstr.Replace(ribr.peak2,"");
                    break;
                }
            }
        }
        if (check==false){
            components.Add(ribr.peak1+ribr.peak2);
            peakstr=peakstr.Replace(ribr.peak1,"").Replace(ribr.peak2,"");
        }
    }
}

Console.WriteLine(components.Count());


