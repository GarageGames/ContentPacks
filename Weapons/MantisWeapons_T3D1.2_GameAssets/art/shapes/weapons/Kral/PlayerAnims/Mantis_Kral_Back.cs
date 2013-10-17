singleton TSShapeConstructor(Mantis_Kral_BackDAE)
{
   baseShape = "./Mantis_Kral_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "450", "479", true, true);
}
