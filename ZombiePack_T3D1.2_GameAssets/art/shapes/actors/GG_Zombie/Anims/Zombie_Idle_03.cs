singleton TSShapeConstructor(Zombie_Idle_03DAE)
{
   baseShape = "./Zombie_Idle_03.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Zombie_Idle_03DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Idle_03", "330", "450");
}
