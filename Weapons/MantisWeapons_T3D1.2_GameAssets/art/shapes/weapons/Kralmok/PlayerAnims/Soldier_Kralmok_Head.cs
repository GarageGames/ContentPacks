singleton TSShapeConstructor(Soldier_Kralmok_HeadDAE)
{
   baseShape = "./Soldier_Kralmok_Head.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "860", "870", true, true);
}
