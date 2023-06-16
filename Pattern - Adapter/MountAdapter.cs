class MountAdapter : IVehicle
{
    private IMount mount;

    public MountAdapter(IMount mount)
    {
        this.mount = mount;
    }

    public void Inspection()
    {
        mount.VisitToDoctor();
    }

    public void Move()
    {
        mount.Control();
    }

    public void Refuel()
    {
        mount.Feed();
        mount.Rest();
    }
}
