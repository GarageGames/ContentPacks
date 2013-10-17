singleton TSShapeConstructor(Mantis_Kral_SideDAE)
{
   baseShape = "./Mantis_Kral_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "510", "529", true, true);
}
