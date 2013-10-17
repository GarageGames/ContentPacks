singleton TSShapeConstructor(PlayerAnim_Mamba_Crouch_BackDAE)
{
   baseShape = "./PlayerAnim_Mamba_Crouch_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Mamba_Crouch_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Back", "460", "489");
}
