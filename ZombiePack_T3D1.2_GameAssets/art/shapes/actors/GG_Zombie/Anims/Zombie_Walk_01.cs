singleton TSShapeConstructor(Zombie_Walk_01DAE)
{
   baseShape = "./Zombie_Walk_01.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Walk_01DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Walk_01", "500", "590");
}
