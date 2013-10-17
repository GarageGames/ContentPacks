singleton TSShapeConstructor(Mantis_Kral_HeadDAE)
{
   baseShape = "./Mantis_Kral_Head.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "960", "970", true, true);
}
