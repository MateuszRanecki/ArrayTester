
using ArrayTester;

bool LoopStop = false;
AppScripts scripts= new AppScripts();
//scripts.AddOriginValue();
void Test() {
    while (!LoopStop) {
        scripts.EditValue();
        Thread.Sleep(5000);        
    }
    
}
Test();
