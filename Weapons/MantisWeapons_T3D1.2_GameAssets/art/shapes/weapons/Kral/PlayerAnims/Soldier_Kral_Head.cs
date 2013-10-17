singleton TSShapeConstructor(Soldier_Kral_HeadDAE)
{
   baseShape = "./Soldier_Kral_Head.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "855", "865", true, true);
}
