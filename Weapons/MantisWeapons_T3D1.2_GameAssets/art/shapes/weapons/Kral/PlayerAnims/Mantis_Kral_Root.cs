singleton TSShapeConstructor(Mantis_Kral_RootDAE)
{
   baseShape = "./Mantis_Kral_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "10", "99", true, true);
}
