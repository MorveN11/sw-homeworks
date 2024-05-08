public class Theater
{
    public Theater() { }

    public void show()
    {
        PuppetMaster<King> kingMaster = new PuppetMaster<King>();
        PuppetMaster<Princess> princessMaster = new PuppetMaster<Princess>();
        PuppetMaster<Commoner> commonerMaster = new PuppetMaster<Commoner>();

        King king = new King();
        Princess princess = new Princess();
        Commoner commoner = new Commoner();

        kingMaster.Perform(king);
        princessMaster.Perform(princess);
        commonerMaster.Perform(commoner);
    }
}
