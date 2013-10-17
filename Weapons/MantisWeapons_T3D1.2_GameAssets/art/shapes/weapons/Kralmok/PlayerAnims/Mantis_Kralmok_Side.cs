singleton TSShapeConstructor(Mantis_Kralmok_SideDAE)
{
   baseShape = "./Mantis_Kralmok_Side.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Side", "510", "529", true, true);
}
