singleton TSShapeConstructor(Zombie_Attack_01DAE)
{
   baseShape = "./Zombie_Attack_01.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Attack_01DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Attack_01", "840", "900");
}
