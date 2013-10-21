singleton TSShapeConstructor(Zombie_Attack_02DAE)
{
   baseShape = "./Zombie_Attack_02.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Attack_02DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Attack_02", "930", "990");
}
