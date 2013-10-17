singleton TSShapeConstructor(Mantis_Kral_Crouch_SideDAE)
{
   baseShape = "./Mantis_Kral_Crouch_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kral_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "740", "769", true, true);
}
