singleton TSShapeConstructor(Mantis_Kralmok_RunDAE)
{
   baseShape = "./Mantis_Kralmok_Run.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "330", "349", true, true);
}
