singleton TSShapeConstructor(Mantis_Kral_RunDAE)
{
   baseShape = "./Mantis_Kral_Run.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_RunDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Run", "330", "349", true, true);
}
