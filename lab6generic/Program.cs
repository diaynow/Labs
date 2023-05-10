Example<int> example=new Example<int>();
example.Add(1);
example.Add(2);
example.Rem(2);
class Example<T>{
    private T[] mass=Array.Empty<T>();
    public T this[int index]{
        get{
            return mass[index];
        }
        set{
            mass[index]=value;
        }
    }
    public void Add(T value){
        var newMass=new T[mass.Length+1];
        for (int i =0; i <newMass.Length; i++)
        {
            newMass[i]=mass[i];
        }
        newMass[mass.Length]=value;
        mass=newMass;
    }
    public void Rem(int value){
        var newMass=new T[mass.Length-1];
        int k=0;
        for (int i =0; i <newMass.Length; i++)
        {
            if (i!=value){
                newMass[k]=mass[i];
                k++;
            }
        }
        mass=newMass;
    }
   
}