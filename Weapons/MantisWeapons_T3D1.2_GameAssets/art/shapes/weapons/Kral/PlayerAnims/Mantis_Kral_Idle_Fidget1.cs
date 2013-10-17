singleton TSShapeConstructor(Mantis_Kral_Idle_Fidget1DAE)
{
   baseShape = "./Mantis_Kral_Idle_Fidget1.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_Idle_Fidget1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Idle_Fidget1", "130", "280", true, true);
}
