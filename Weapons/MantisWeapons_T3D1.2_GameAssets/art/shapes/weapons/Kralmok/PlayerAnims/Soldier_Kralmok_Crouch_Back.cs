singleton TSShapeConstructor(Soldier_Kralmok_Crouch_BackDAE)
{
   baseShape = "./Soldier_Kralmok_Crouch_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kralmok_Crouch_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Back", "440", "469", true, true);
}
