singleton TSShapeConstructor(Mantis_Kralmok_Idle_Fidget1DAE)
{
   baseShape = "./Mantis_Kralmok_Idle_Fidget1.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_Idle_Fidget1DAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Idle_Fidget1", "130", "280", true, true);
}
