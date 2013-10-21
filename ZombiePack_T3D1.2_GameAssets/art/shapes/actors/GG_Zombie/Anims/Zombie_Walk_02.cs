singleton TSShapeConstructor(Zombie_Walk_02DAE)
{
   baseShape = "./Zombie_Walk_02.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Walk_02DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Walk_02", "620", "710");
}
