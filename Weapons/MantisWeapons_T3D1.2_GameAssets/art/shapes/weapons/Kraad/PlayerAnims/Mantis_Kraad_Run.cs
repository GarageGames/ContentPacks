singleton TSShapeConstructor(Mantis_Kraad_RunDAE)
{
   baseShape = "./Mantis_Kraad_Run.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kraad_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "330", "349", true, true);
}
